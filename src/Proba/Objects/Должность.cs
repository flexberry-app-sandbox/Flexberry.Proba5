﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Proba
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Должность.
    /// </summary>
    // *** Start programmer edit section *** (Должность CustomAttributes)

    // *** End programmer edit section *** (Должность CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДолжностьE", new string[] {
            "ID as \'ID\'",
            "Название as \'Название\'",
            "Оклад as \'Оклад\'"})]
    [View("ДолжностьL", new string[] {
            "ID as \'ID\'",
            "Название as \'Название\'",
            "Оклад as \'Оклад\'"})]
    public class Должность : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fНазвание;
        
        private int fОклад;
        
        // *** Start programmer edit section *** (Должность CustomMembers)

        // *** End programmer edit section *** (Должность CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Должность.ID CustomAttributes)

        // *** End programmer edit section *** (Должность.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Должность.ID Get start)

                // *** End programmer edit section *** (Должность.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Должность.ID Get end)

                // *** End programmer edit section *** (Должность.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Должность.ID Set start)

                // *** End programmer edit section *** (Должность.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Должность.ID Set end)

                // *** End programmer edit section *** (Должность.ID Set end)
            }
        }
        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Должность.Название CustomAttributes)

        // *** End programmer edit section *** (Должность.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Должность.Название Get start)

                // *** End programmer edit section *** (Должность.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Должность.Название Get end)

                // *** End programmer edit section *** (Должность.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Должность.Название Set start)

                // *** End programmer edit section *** (Должность.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Должность.Название Set end)

                // *** End programmer edit section *** (Должность.Название Set end)
            }
        }
        
        /// <summary>
        /// Оклад.
        /// </summary>
        // *** Start programmer edit section *** (Должность.Оклад CustomAttributes)

        // *** End programmer edit section *** (Должность.Оклад CustomAttributes)
        public virtual int Оклад
        {
            get
            {
                // *** Start programmer edit section *** (Должность.Оклад Get start)

                // *** End programmer edit section *** (Должность.Оклад Get start)
                int result = this.fОклад;
                // *** Start programmer edit section *** (Должность.Оклад Get end)

                // *** End programmer edit section *** (Должность.Оклад Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Должность.Оклад Set start)

                // *** End programmer edit section *** (Должность.Оклад Set start)
                this.fОклад = value;
                // *** Start programmer edit section *** (Должность.Оклад Set end)

                // *** End programmer edit section *** (Должность.Оклад Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДолжностьE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДолжностьE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДолжностьE", typeof(IIS.Proba.Должность));
                }
            }
            
            /// <summary>
            /// "ДолжностьL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДолжностьL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДолжностьL", typeof(IIS.Proba.Должность));
                }
            }
        }
    }
}
