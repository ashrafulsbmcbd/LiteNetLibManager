﻿using LiteNetLib.Utils;

namespace LiteNetLibManager
{
    public class NetFieldShort : LiteNetLibNetField<short>
    {
        public override void Deserialize(NetDataReader reader)
        {
            Value = reader.GetShort();
        }

        public override void Serialize(NetDataWriter writer)
        {
            writer.Put(Value);
        }

        public override bool IsValueChanged(short newValue)
        {
            return newValue != Value;
        }
    }
}
