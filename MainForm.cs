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
using System.Threading;
using System.IO;

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
        private async void MainForm_Load(object sender, EventArgs e){
            // Сплеш-скрин
            Splash sp = new Splash(); // Инициализировать объект формы
            sp.ShowDialog(); // Показать форму
            this.Visible = true; // Показать форму
            this.Show(); // Показать

            // Загрузка последних проектов
            this.Enabled = false; // Отключить форму
            this.UseWaitCursor = true; // Курсор ожидания
            var progress = new Progress<int>(percent => { // Новый прогресс
                state_progress.Value = percent; // Указать процесс операции
            });

            // Выполняем асинхронную операцию чтения
            App.Project.latest = new List<string>(); // Создать список последних проектов
            bool getLatestList = await Task.Run(() => App.Project.get_latest_projects(progress)); // Получить последние проекты
            state_progress.Value = 0; // Сбросить прогресс
            this.Enabled = true; // Активировать форму
            this.UseWaitCursor = false; // Курсор ожидания

            // Теперь обновляем список последних проектов в зависимости от ответа
            if (!getLatestList) { // Если был получен список
                ToolStripMenuItem item = new ToolStripMenuItem(); // Новый объект
                item.Text = "Нет последних проектов"; // Установить текст
                item.Enabled = false; // Установить принадлежность
                latest_project_but.DropDownItems.Add(item); // Добавить объект
            } else { // Если список не был получен
                if(App.Project.latest.Count>0){ // Только если есть проекты
                    for (int i = 0; i < App.Project.latest.Count; i++) { // Перебор списка проектов
                        ToolStripMenuItem item = new ToolStripMenuItem(); // Новый объект
                        item.Text = App.Project.latest.ElementAt(i).ToString(); // Установить текст
                        item.Enabled = true; // Установить принадлежность
                        item.Click += new EventHandler(App.Project.latest_open); // Handlers на нажатие
                        latest_project_but.DropDownItems.Add(item); // Добавить объект
                    }
                }else{ // Проектов нет
                    ToolStripMenuItem item = new ToolStripMenuItem(); // Новый объект
                    item.Text = "Нет последних проектов"; // Установить текст
                    item.Enabled = false; // Установить принадлежность
                    latest_project_but.DropDownItems.Add(item); // Добавить объект
                }
            }
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
        }

        //===============================================//
        //  Настройки компилятора
        //===============================================//
        private void opt_compile_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Настройки интерфейса
        //===============================================//
        private void opt_ui_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Обновление программы
        //===============================================//
        private void opt_update_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Компилировать проект
        //===============================================//
        private void compile_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Настройки компиляции проекта
        //===============================================//
        private void options_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Создание нового проекта
        //===============================================//
        private void new_project_but_Click(object sender, EventArgs e) {
            W2W_SDK.Forms.Project.NewProject np = new Forms.Project.NewProject(); // Создать экземпляр формы
            if (np.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { // Нажата кнопка "Создать"
                MessageBox.Show("123");
            }
        }

        //===============================================//
        //  Сохранение проекта
        //===============================================//
        private async void save_project_but_Click(object sender, EventArgs e) {

        }

        //===============================================//
        //  Сохранить проект "Как"
        //===============================================//
        private async void saveas_project_but_Click(object sender, EventArgs e) {

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
            public static void save(IProgress<int> progress) {

            }

            //===============================================//
            //  Сохранить проект как
            //===============================================//
            public static void save_as(IProgress<int> progress) {

            }

            //===============================================//
            //  Получить последние проекты
            //===============================================//
            public static bool get_latest_projects(IProgress<int> progress) {
                // Получаем список последних проектов (Если есть)
                if(File.Exists(Application.StartupPath+"/latest.lst")){ // Если есть список
                    try{ // Попытка чтения
                        // Добавление списка элементов путем построчного считывания
                        progress.Report(50); // Прогресс
                        Project.latest.Clear(); // Очистить список
                        using (StreamReader r = new StreamReader(Application.StartupPath+"/latest.lst")){ // Используя ридер
	                        string line; // Строка
	                        while ((line = r.ReadLine()) != null){ // До конца файла
		                        Project.latest.Add(line); // Добавить в список
	                        }
	                    }
                        progress.Report(100); // Прогресс

                        // Вернуть ответ
                        return true; // Есть список
                    }catch(Exception e){ // Ошибка чтения
                        progress.Report(100); // Прогресс
                        Project.latest.Clear(); // Очистить список
                        Project.latest.Add("Нет элементов"); // Добавить в список

                        // Вернуть ответ
                        return false; // Нет списка
                    }
                }else{ // Списка нет
                    progress.Report(100); // Прогресс
                    Project.latest.Clear(); // Очистить список
                    Project.latest.Add("Нет элементов"); // Добавить в список

                    // Вернуть ответ
                    return false; // Нет списка
                }
            }

            //===============================================//
            //  Нажатие на последний проект
            //===============================================//
            public static async void latest_open(dynamic sender, EventArgs e) {
                
            }
        }
        
    }
}
