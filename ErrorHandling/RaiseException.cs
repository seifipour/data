using System;


namespace ClassLibrary1
{
    public class RaiseException
    {
        public void NameOfUser(string name)
        {
            if(name=="Salam")
            {
                throw new ArgumentException("Salam is not name");
            }
        }
       public string MultipleCatches()
       {
           string exceptionMessage = string.Empty;
           try
           {
               NameOfUser("Salam");
           }
           catch (DivideByZeroException exception)
           {
               
              exceptionMessage="Divided by Zero";
           }
           catch(ArgumentException exception)
           {
               exceptionMessage = "Argument Exception";
           }
           catch(Exception exception)
           {
               exceptionMessage = "General Exception";
           }
           finally
           {
               exceptionMessage = exceptionMessage + "Finally";
           }
           return exceptionMessage;
       }
        public void Innercatchblock()
        {
            try
            {
                MultipleCatches();
            }
            catch (Exception)
            {
                
                throw new Exception();
            }
        }
    }
    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
