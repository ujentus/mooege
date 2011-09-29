using System.Text;

namespace Mooege.Net.GS.Message.Fields
{
    public class GameId
    {
        public long Field0;
        public long Field1;
        public long Field2;

        public void Parse(GameBitBuffer buffer)
        {
            Field0 = buffer.ReadInt64(64);
            Field1 = buffer.ReadInt64(64);
            Field2 = buffer.ReadInt64(64);
        }

        public void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt64(64, Field0);
            buffer.WriteInt64(64, Field1);
            buffer.WriteInt64(64, Field2);
        }

        public void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("GameId:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            b.Append(' ', pad);
            b.AppendLine("Field0: 0x" + Field0.ToString("X16"));
            b.Append(' ', pad);
            b.AppendLine("Field1: 0x" + Field1.ToString("X16"));
            b.Append(' ', pad);
            b.AppendLine("Field2: 0x" + Field2.ToString("X16"));
            b.Append(' ', --pad);
            b.AppendLine("}");
        }


    }
}