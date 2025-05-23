// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalMessageDeltaObjectObject : IEquatable<InternalMessageDeltaObjectObject>
    {
        private readonly string _value;
        private const string ThreadMessageDeltaValue = "thread.message.delta";

        public InternalMessageDeltaObjectObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalMessageDeltaObjectObject ThreadMessageDelta { get; } = new InternalMessageDeltaObjectObject(ThreadMessageDeltaValue);

        public static bool operator ==(InternalMessageDeltaObjectObject left, InternalMessageDeltaObjectObject right) => left.Equals(right);

        public static bool operator !=(InternalMessageDeltaObjectObject left, InternalMessageDeltaObjectObject right) => !left.Equals(right);

        public static implicit operator InternalMessageDeltaObjectObject(string value) => new InternalMessageDeltaObjectObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageDeltaObjectObject other && Equals(other);

        public bool Equals(InternalMessageDeltaObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
