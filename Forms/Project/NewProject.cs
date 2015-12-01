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
using System.IO;

//===============================================//
//  Создаем пространство имен
//===============================================//
namespace W2W_SDK.Forms.Project {
    //===============================================//
    //  Класс формы создания проекта
    //===============================================//
    public partial class NewProject : Form {
        //===============================================//
        //  Конструктор класса
        //===============================================//
        public NewProject() {
            InitializeComponent(); // Инициализировать компонент
        }

        //===============================================//
        //  Асинхронная загрузка формы
        //===============================================//
        private async void NewProject_Load(object sender, EventArgs e) {
            
        }

        //===============================================//
        //  Нажатие "Создать"
        //===============================================//
        private void prj_creation_ok_Click(object sender, EventArgs e) {
            // При нажатии кнопки мы будем создавать файл проекта с опциями.
            // но для этого нужно указать параметры и закрыть диалог
            
        }

        //===============================================//
        //  Нажатие "Обзор" для поля "Папка проекта (TPL)"
        //===============================================//
        private void tpl_prj_path_but_Click(object sender, EventArgs e) {
            if (choose_prj_dir.ShowDialog() == System.Windows.Forms.DialogResult.OK) { // Если директория выбрана
                if (File.Exists(choose_prj_dir.SelectedPath + "/project.w2wproj")) { // Уже существует проект
                    MessageBox.Show("Вы не можете выбрать данную рабочую директорию, поскольку в ней уже находится другой проект", "Проект уже существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { // Проекта не существует
                    tpl_prj_path.Text = choose_prj_dir.SelectedPath; // Выбранная папка
                }
            }
        }

        //===============================================//
        //  Нажатие "Обзор" для поля "Папка сурсов (HTML)"
        //===============================================//
        private void html_prj_source_but_Click(object sender, EventArgs e) {
            if (choose_html_dir.ShowDialog() == System.Windows.Forms.DialogResult.OK) { // Если директория выбрана
                if (!File.Exists(choose_html_dir.SelectedPath + "/index.html")) { // Уже существует проект
                    MessageBox.Show("В данной папке отсутствует индексный HTML-файл (index.html). Ваше HTML5 приложение должно содержать индексный файл.", "Отсутствует индексный файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { // Проекта не существует
                    html_prj_source.Text = choose_html_dir.SelectedPath; // Выбранная папка
                }
            }
        }

        //===============================================//
        //  Нажатие "Обзор" для поля "Папка проекта (HTML)"
        //===============================================//
        private void html_prj_path_but_Click(object sender, EventArgs e) {
            if (choose_prj_dir.ShowDialog() == System.Windows.Forms.DialogResult.OK) { // Если директория выбрана
                if (File.Exists(choose_prj_dir.SelectedPath + "project.w2wproj")) { // Уже существует проект
                    MessageBox.Show("Вы не можете выбрать данную рабочую директорию, поскольку в ней уже находится другой проект", "Проект уже существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { // Проекта не существует
                    html_prj_path.Text = choose_prj_dir.SelectedPath; // Выбранная папка
                }
            }
        }
    }
}
