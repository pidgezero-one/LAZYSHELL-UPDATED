using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LAZYSHELL
{
    [Serializable()]
    public class ImagePacket
    {
        // universal variables
        private byte[] rom { get { return Model.ROM; } set { Model.ROM = value; } }
        private int index; public int Index { get { return index; } set { index = value; } }
        // class variables and accessors
        private int paletteOffset; public int PaletteOffset { get { return paletteOffset; } set { paletteOffset = value; } }
        private int graphicOffset; public int GraphicOffset { get { return graphicOffset; } set { graphicOffset = value; } }
        private int paletteNum; public int PaletteNum { get { return paletteNum; } set { paletteNum = value; } }
        // constructor
        public ImagePacket(int index)
        {
            this.index = index;
            Disassemble();
        }
        // assemblers
        private void Disassemble()
        {
            int offset = (index * 4) + 0x251800;
            int bank = (int)(((rom[offset] & 0x0F) << 16) + RomConfig.SpriteGraphicsBaseAddress);
            graphicOffset = (int)((Bits.GetShort(rom, offset) & 0xFFF0) + bank); offset += 2;
            paletteOffset = (int)(Bits.GetShort(rom, offset) + 0x250000);
            //
            if (paletteOffset < 0x253000) 
                paletteOffset = 0x253000;
            paletteNum = (paletteOffset - 0x253000) / 30;
        }
        public void Assemble()
        {
            int offset = (index * 4) + 0x251800;
            byte bank = (byte)((graphicOffset - RomConfig.SpriteGraphicsBaseAddress) >> 16);
            ushort pointer = (ushort)(graphicOffset & 0xFFF0);
            Bits.SetShort(rom, offset, pointer);
            rom[offset] |= bank; offset += 2;
            //
            Bits.SetShort(rom, offset, (ushort)(paletteNum * 30 + 0x3000));
        }
        // accessor functions
        public byte[] Graphics(byte[] spriteGraphics)
        {
            // Bounds check: ensure we don't read beyond SpriteGraphics buffer (0xF87C0 bytes)
            int srcOffset = graphicOffset - RomConfig.SpriteGraphicsBaseAddress;
            if (srcOffset < 0 || srcOffset >= spriteGraphics.Length)
            {
                // Return empty array if offset is invalid
                return new byte[0x4000];
            }
            int availableBytes = spriteGraphics.Length - srcOffset;
            int bytesToRead = Math.Min(0x4000, availableBytes);
            if (bytesToRead <= 0)
                return new byte[0x4000];

            byte[] result = new byte[0x4000];
            Array.Copy(spriteGraphics, srcOffset, result, 0, bytesToRead);
            return result;
        }
    }
}
