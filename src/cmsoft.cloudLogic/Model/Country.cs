/*
* Copyright (c) Carlos Mario.
* Please, read the document https://github.com/carlosprogrammer/phonebook-service/blob/master/LICENSE
* of this code
*
*
*
*
*
*
*
*
* 
* 
* <carlos_programmer10@hotmail.com>
*/





using System;

namespace cmsoft.cloudLogic.Model
{
    /// <summary>
    /// Represent the a numeric code each country.
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class Country
    {

        #region attributes region

        /// <summary>
        /// The country's numeric code.
        /// </summary>
        private String _strCode;

        /// <summary>
        /// The country's name
        /// </summary>
        private String _strName;

        #endregion


        #region the properties region

        /// <summary>
        /// Gets or sets the country's name
        /// </summary>
        public String Name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        /// <summary>
        /// Gets or sets the country's code
        /// </summary>
        public String Code
        {
            get { return _strCode; }
            set { _strCode = value; }
        }

        #endregion
    }
}
