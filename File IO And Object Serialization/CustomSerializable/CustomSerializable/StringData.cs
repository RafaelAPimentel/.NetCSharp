using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerializable
{
    [Serializable]
    class StringData
    {
        private string dataItemOne = "First data block";
        private string dataItemTwo = "More data";

        public StringData() { }

        [OnSerialized]
        private void OnSerializing(StreamingContext context)
        {
            //called during the serialization process
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnDeserializing]
        private void OnDeserializaing(StreamingContext context)
        {
            //called during the deserialization process is ocmplete
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }

        //This is to implement  the ISerializable interface on your own instead of using the attributes above

        //protected StringData(SerializationInfo si, StreamingContext ctx)
        //{
        //    //Rehydrate member variable from state
        //    dataItemOne = si.GetString("First_Item").ToLower();
        //    dataItemTwo = si.GetString("dataItemTwo").ToUpper();
        //}
        //void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    //Fill up the Serializable object with the formatted data.
        //    info.AddValue("First_Item", dataItemOne.ToUpper());
        //    info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
        //}
    }
}
