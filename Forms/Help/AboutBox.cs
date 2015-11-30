//===============================================//
//  Файл:               AboutBox.cs
//  Назначение:         Окно "О программе"
//  Разработчик:        InterWave Partnership
//===============================================//
//===============================================//
//  Подключение компонентов
//===============================================//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

//===============================================//
//  Создаем пространство имен
//===============================================//
namespace W2W_SDK.Forms.Help {
    //===============================================//
    //  Класс окна приложения
    //===============================================//
    partial class AboutBox : Form {
        //===============================================//
        //  Конструктор класса
        //===============================================//
        public AboutBox() {
            InitializeComponent(); // Инициализировать компонент
            this.Text = String.Format("О программе {0}", AssemblyTitle); // Имя сборки
            this.labelProductName.Text = String.Format("Продукт: {0}", AssemblyProduct); // Имя продукта
            this.labelVersion.Text = String.Format("Версия: {0}", AssemblyVersion); // Версия программы
            this.labelCopyright.Text = String.Format("Копирайт: {0}", AssemblyCopyright); // Копирайт
            this.labelCompanyName.Text = String.Format("Разработчик: {0}",AssemblyCompany); // Компания
            this.textBoxDescription.Text = AssemblyDescription; // Описание
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        //===============================================//
        //  Нажатие кнопки "Ок"
        //===============================================//
        private void okButton_Click(object sender, EventArgs e) {
            this.Close(); // Закрыть форму
        }
    }
}
