//===============================================//
//  Файл:               MainForm.cs
//  Назначение:         Главное окно программы
//  Разработчик:        InterWave Partnership
//===============================================//
//===============================================//
//  Подключение компонентов
//===============================================//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//===============================================//
//  Создаем пространство имен
//===============================================//
namespace W2W_SDK{
    //===============================================//
    //  Класс главной формы приложения
    //===============================================//
    public partial class MainForm : Form{
        //===============================================//
        //  Конструктор класса
        //===============================================//
        public MainForm(){
            InitializeComponent(); // Инициализировать компонент
        }

        //===============================================//
        //  Загрузка формы
        //===============================================//
        private void MainForm_Load(object sender, EventArgs e){
            // Сплеш-скрин
            Splash sp = new Splash(); // Инициализировать объект формы
            sp.ShowDialog(); // Показать форму
            this.Visible = true; // Показать форму
            this.Show(); // Показать
        }

        //===============================================//
        //  Закрытие формы
        //===============================================//
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e){
            // Проверка несохраненных данных перед закрытием
            if (App.Project.opened && App.Project.changes) { // Если открыт проект и есть изменения без сохранения
                if (MessageBox.Show(this, "У вас имеются несохраненные изменения в проекте. Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) {
                    e.Cancel = true; // Отменить закрытие
                }
            }

            // Сохранить настройки
            W2W_SDK.Properties.Settings.Default.Save(); // Сохранить настройки
        }

        //===============================================//
        //  Кнопки выхода
        //===============================================//
        private void quit_but_Click(object sender, EventArgs e){
            this.Close(); // Закрыть
        } // Меню приложения
        private void n_quit_but_Click(object sender, EventArgs e){
            this.Close(); // Закрыть
        } // Меню области уведомлений

        //===============================================//
        //  Открыть проект
        //===============================================//
        private async void open_project_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Свернуть/Открыть из области уведомлений
        //===============================================//
        private void n_hide_but_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized; // Свернуть окно
        } // Свернуть
        private void n_open_but_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal; // Показать окно
        }

        //===============================================//
        //  Нажатие кнопки "О программе"
        //===============================================//
        private void about_but_Click(object sender, EventArgs e) {
            W2W_SDK.Forms.Help.AboutBox about = new W2W_SDK.Forms.Help.AboutBox(); // Новый экземпляр формы
            about.ShowDialog(this); // Отобразить диалог
        }

        //===============================================//
        //  Нажатие кнопки "Справка"
        //===============================================//
        private void docs_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Переход на сайт продукта
        //===============================================//
        private void soft_site_but_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://services.iwaps.ru/w2w-sdk/"); // Перейти на сайт
        }

        //===============================================//
        //  Переход на сайт разработчика
        //===============================================//
        private void dev_site_but_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://iwaps.ru/"); // Перейти на сайт
        }

        //===============================================//
        //  Переход в Github
        //===============================================//
        private void gh_but_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/iwadev"); // Перейти на сайт
        } // Открыть


    }

    //===============================================//
    //  Класс функций приложения
    //===============================================//
    public static class App{
        //===============================================//
        //  Параметры класса
        //===============================================//
        public static List<Control> FControls; // Список контроллов для выполнения

        //===============================================//
        //  Параметры объекта
        //===============================================//
        public static class Project{
            // Общие параметры
            public static List<string> latest; // Последние проекты

            // Параметры проекта
            public static bool opened = false; // Открыт ли проект
            public static bool changes = false; // Есть ли изменения?
            public static string uri = ""; // Папка проекта
            public static string source_path = ""; // Папка исходников
            public static string build_path = ""; // Папка сборки проекта

            //===============================================//
            //  Открыть проект
            //===============================================//
            public static void open(string filename, IProgress<int> progress) {

            }

            //===============================================//
            //  Сохранить проект
            //===============================================//
            public static void save() {

            }

            //===============================================//
            //  Сохранить проект как
            //===============================================//
            public static void save_as() {

            }

            //===============================================//
            //  Получить последние проекты
            //===============================================//
            public static bool get_latest_projects(){
                return true;
            }
        }
        
    }
}
