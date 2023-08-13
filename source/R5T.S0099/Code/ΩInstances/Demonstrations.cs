using System;


namespace R5T.S0099
{
    public class Demonstrations : IDemonstrations
    {
        #region Infrastructure

        public static IDemonstrations Instance { get; } = new Demonstrations();


        private Demonstrations()
        {
        }

        #endregion
    }
}
