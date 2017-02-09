﻿using System;

namespace ObcidiaNetwork.Base
{
    internal class ConnectionBase : ICloneable
    {
        public int NeuronFromId;
        public int NeuronToId;

        public float WeightValue;

        public ConnectionBase()
        {
            NeuronFromId = 0;
            NeuronToId = 0;

            WeightValue = 0f;
        }

        protected bool Equals(ConnectionBase other)
        {
            return NeuronFromId == other.NeuronFromId && NeuronToId == other.NeuronToId && WeightValue.Equals(other.WeightValue);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ConnectionBase) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = NeuronFromId;
                hashCode = (hashCode * 397) ^ NeuronToId;
                hashCode = (hashCode * 397) ^ WeightValue.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(ConnectionBase left, ConnectionBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConnectionBase left, ConnectionBase right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{{\"from\":{NeuronFromId},\"to\":{NeuronToId},\"weight\":{WeightValue}}}";
        }

        public object Clone()
        {
            ConnectionBase obj = new ConnectionBase
            {
                NeuronToId = NeuronToId,
                NeuronFromId = NeuronFromId,
                WeightValue = WeightValue
            };

            return obj;
        }
    }
}