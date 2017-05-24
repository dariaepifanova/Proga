using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Proga
{
    [Serializable]
    public class Skates : ISerializable
    {
        private int id;
        private bool gender; // 0 - woman, 1 - man
        private int size;

        public Skates() { }
        public Skates(int id, bool gender, int size)
        {
            this.id = id;
            Gender = gender;
            Size = size;
        }

        public override string ToString()
        {
            return String.Format("{0};{1};{2}", Id, Gender, Size);
        }

        public Skates(SerializationInfo info, StreamingContext content)
        {
            this.id = (int)info.GetValue("Id", typeof(int));
            this.size = (int)info.GetValue("Size", typeof(int));
            this.gender = (bool)info.GetValue("Gender", typeof(bool));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext content)
        {
            info.AddValue("Id", this.id);
            info.AddValue("Size", this.size);
            info.AddValue("Gender", this.Gender);
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value < 26 || value > 47)
                    throw new ArgumentOutOfRangeException("Size is not correct!");
                size = value;
            }
        }
    }
}
