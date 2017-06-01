namespace DynamicKeyword
{
    internal class VeryDynamicClass
    {
        //dynamic field
        private static dynamic myDynamicField;

        // dynamic property
        public dynamic DynamicProperty { get; set; }

        public dynamic DynamicMethod(dynamic dynamicParam) {
            //dynamic local variable
            dynamic dynamicLocalVar = "Local Variable";

            int myInt = 110;

            if (dynamicParam is int)
            {
                return dynamicLocalVar;
            }
            else
            {
                return myInt;
            }
        }
    }
}