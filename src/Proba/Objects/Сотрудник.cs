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
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникE", new string[] {
            "ID as \'ID\'",
            "ФИО as \'ФИО\'",
            "Контакты as \'Контакты\'",
            "Образование as \'Образование\'",
            "Опыт_работы as \'Опыт_работы\'",
            "Дата_приема as \'Дата_приема\'",
            "Должность as \'Должность\'",
            "Должность.Название as \'Название\'"}, Hidden=new string[] {
            "Должность.Название"})]
    [MasterViewDefineAttribute("СотрудникE", "Должность", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("СотрудникL", new string[] {
            "ID as \'ID\'",
            "ФИО as \'ФИО\'",
            "Контакты as \'Контакты\'",
            "Образование as \'Образование\'",
            "Опыт_работы as \'Опыт_работы\'",
            "Дата_приема as \'Дата_приема\'",
            "Должность.Название as \'Название\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fФИО;
        
        private string fКонтакты;
        
        private string fОбразование;
        
        private string fОпыт_работы;
        
        private System.DateTime fДата_приема;
        
        private IIS.Proba.Должность fДолжность;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ID CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ID Get start)

                // *** End programmer edit section *** (Сотрудник.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Сотрудник.ID Get end)

                // *** End programmer edit section *** (Сотрудник.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ID Set start)

                // *** End programmer edit section *** (Сотрудник.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Сотрудник.ID Set end)

                // *** End programmer edit section *** (Сотрудник.ID Set end)
            }
        }
        
        /// <summary>
        /// Дата_приема.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Дата_приема CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Дата_приема CustomAttributes)
        public virtual System.DateTime Дата_приема
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Дата_приема Get start)

                // *** End programmer edit section *** (Сотрудник.Дата_приема Get start)
                System.DateTime result = this.fДата_приема;
                // *** Start programmer edit section *** (Сотрудник.Дата_приема Get end)

                // *** End programmer edit section *** (Сотрудник.Дата_приема Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Дата_приема Set start)

                // *** End programmer edit section *** (Сотрудник.Дата_приема Set start)
                this.fДата_приема = value;
                // *** Start programmer edit section *** (Сотрудник.Дата_приема Set end)

                // *** End programmer edit section *** (Сотрудник.Дата_приема Set end)
            }
        }
        
        /// <summary>
        /// Контакты.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Контакты CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Контакты CustomAttributes)
        [StrLen(255)]
        public virtual string Контакты
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Контакты Get start)

                // *** End programmer edit section *** (Сотрудник.Контакты Get start)
                string result = this.fКонтакты;
                // *** Start programmer edit section *** (Сотрудник.Контакты Get end)

                // *** End programmer edit section *** (Сотрудник.Контакты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Контакты Set start)

                // *** End programmer edit section *** (Сотрудник.Контакты Set start)
                this.fКонтакты = value;
                // *** Start programmer edit section *** (Сотрудник.Контакты Set end)

                // *** End programmer edit section *** (Сотрудник.Контакты Set end)
            }
        }
        
        /// <summary>
        /// Образование.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Образование CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Образование CustomAttributes)
        [StrLen(255)]
        public virtual string Образование
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Образование Get start)

                // *** End programmer edit section *** (Сотрудник.Образование Get start)
                string result = this.fОбразование;
                // *** Start programmer edit section *** (Сотрудник.Образование Get end)

                // *** End programmer edit section *** (Сотрудник.Образование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Образование Set start)

                // *** End programmer edit section *** (Сотрудник.Образование Set start)
                this.fОбразование = value;
                // *** Start programmer edit section *** (Сотрудник.Образование Set end)

                // *** End programmer edit section *** (Сотрудник.Образование Set end)
            }
        }
        
        /// <summary>
        /// Опыт_работы.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Опыт_работы CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Опыт_работы CustomAttributes)
        [StrLen(255)]
        public virtual string Опыт_работы
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Опыт_работы Get start)

                // *** End programmer edit section *** (Сотрудник.Опыт_работы Get start)
                string result = this.fОпыт_работы;
                // *** Start programmer edit section *** (Сотрудник.Опыт_работы Get end)

                // *** End programmer edit section *** (Сотрудник.Опыт_работы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Опыт_работы Set start)

                // *** End programmer edit section *** (Сотрудник.Опыт_работы Set start)
                this.fОпыт_работы = value;
                // *** Start programmer edit section *** (Сотрудник.Опыт_работы Set end)

                // *** End programmer edit section *** (Сотрудник.Опыт_работы Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ФИО CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ФИО Get start)

                // *** End programmer edit section *** (Сотрудник.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Сотрудник.ФИО Get end)

                // *** End programmer edit section *** (Сотрудник.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ФИО Set start)

                // *** End programmer edit section *** (Сотрудник.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Сотрудник.ФИО Set end)

                // *** End programmer edit section *** (Сотрудник.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Должность CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Должность CustomAttributes)
        [PropertyStorage(new string[] {
                "Должность"})]
        [NotNull()]
        public virtual IIS.Proba.Должность Должность
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Get start)

                // *** End programmer edit section *** (Сотрудник.Должность Get start)
                IIS.Proba.Должность result = this.fДолжность;
                // *** Start programmer edit section *** (Сотрудник.Должность Get end)

                // *** End programmer edit section *** (Сотрудник.Должность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Должность Set start)

                // *** End programmer edit section *** (Сотрудник.Должность Set start)
                this.fДолжность = value;
                // *** Start programmer edit section *** (Сотрудник.Должность Set end)

                // *** End programmer edit section *** (Сотрудник.Должность Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникE", typeof(IIS.Proba.Сотрудник));
                }
            }
            
            /// <summary>
            /// "СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникL", typeof(IIS.Proba.Сотрудник));
                }
            }
        }
    }
}
