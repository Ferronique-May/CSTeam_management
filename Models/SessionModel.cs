namespace Website.Models
{
    public class SessionModel
    {
        public bool sessionState { get; private set;}
        public bool InvalidateSession() {
            return false;
            //testing, remove later :P
        }
        public bool ValidateSession() {
            return true;
            // return sessionState or something
        }
    }
}