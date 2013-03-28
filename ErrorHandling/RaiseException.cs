using System;


namespace ClassLibrary1
{
    public class RaiseException
    {
        public void NameOfUser(string name)
        {
            if (name == "Hi")
            {
                throw new ArgumentException("Hi is not name");
            }
        }

        public string MultipleCatches()
        {
            string exceptionMessage = string.Empty;
            try
            {
                NameOfUser("Hi");
            }
            catch (DivideByZeroException exception)
            {

                exceptionMessage = "Divided by Zero";
            }
            catch (ArgumentException exception)
            {
                exceptionMessage = "Argument Exception";
            }
            catch (Exception exception)
            {
                exceptionMessage = "General Exception";
            }
            finally
            {
                exceptionMessage = exceptionMessage + "Finally";
            }
            return exceptionMessage;
        }

    }
}
