namespace W2W_SDK
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.file_list = new System.Windows.Forms.ToolStripMenuItem();
            this.new_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.open_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.save_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.saveas_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.latest_project_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quit_but = new System.Windows.Forms.ToolStripMenuItem();
            this.build_list = new System.Windows.Forms.ToolStripMenuItem();
            this.compile_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.options_but = new System.Windows.Forms.ToolStripMenuItem();
            this.options_list = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_compile_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.opt_ui_but = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_update_but = new System.Windows.Forms.ToolStripMenuItem();
            this.help_list = new System.Windows.Forms.ToolStripMenuItem();
            this.about_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.docs_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.soft_site_but = new System.Windows.Forms.ToolStripMenuItem();
            this.dev_site_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.gh_but = new System.Windows.Forms.ToolStripMenuItem();
            this.state_bar = new System.Windows.Forms.StatusStrip();
            this.state_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.open_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.save_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.n_open_but = new System.Windows.Forms.ToolStripMenuItem();
            this.n_hide_but = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.n_quit_but = new System.Windows.Forms.ToolStripMenuItem();
            this.form_container = new System.Windows.Forms.Panel();
            this.project_tabs = new System.Windows.Forms.TabControl();
            this.project_options = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.build_project_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gr_prj_name = new System.Windows.Forms.GroupBox();
            this.prj_name_text = new System.Windows.Forms.TextBox();
            this.gr_dev_name = new System.Windows.Forms.GroupBox();
            this.prj_developer_text = new System.Windows.Forms.TextBox();
            this.gr_prj_version = new System.Windows.Forms.GroupBox();
            this.gr_prj_desc = new System.Windows.Forms.GroupBox();
            this.prj_desc_text = new System.Windows.Forms.TextBox();
            this.gr_prj_product = new System.Windows.Forms.GroupBox();
            this.prj_product_text = new System.Windows.Forms.TextBox();
            this.gr_prj_copyright = new System.Windows.Forms.GroupBox();
            this.prj_copyright_text = new System.Windows.Forms.TextBox();
            this.gr_prj_trademark = new System.Windows.Forms.GroupBox();
            this.prj_trademark_text = new System.Windows.Forms.TextBox();
            this.prj_version_text = new System.Windows.Forms.MaskedTextBox();
            this.gr_prj_icon = new System.Windows.Forms.GroupBox();
            this.prj_icon_but = new System.Windows.Forms.Button();
            this.prj_icon_text = new System.Windows.Forms.TextBox();
            this.gr_type = new System.Windows.Forms.GroupBox();
            this.compile_type = new System.Windows.Forms.ComboBox();
            this.gr_app_type = new System.Windows.Forms.GroupBox();
            this.app_type = new System.Windows.Forms.ComboBox();
            this.gr_res_type = new System.Windows.Forms.GroupBox();
            this.resource_type = new System.Windows.Forms.ComboBox();
            this.gr_how_to = new System.Windows.Forms.GroupBox();
            this.HowToLabel = new System.Windows.Forms.Label();
            this.gr_system = new System.Windows.Forms.GroupBox();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.menu_bar.SuspendLayout();
            this.state_bar.SuspendLayout();
            this.notify_menu.SuspendLayout();
            this.form_container.SuspendLayout();
            this.project_tabs.SuspendLayout();
            this.project_options.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gr_prj_name.SuspendLayout();
            this.gr_dev_name.SuspendLayout();
            this.gr_prj_version.SuspendLayout();
            this.gr_prj_desc.SuspendLayout();
            this.gr_prj_product.SuspendLayout();
            this.gr_prj_copyright.SuspendLayout();
            this.gr_prj_trademark.SuspendLayout();
            this.gr_prj_icon.SuspendLayout();
            this.gr_type.SuspendLayout();
            this.gr_app_type.SuspendLayout();
            this.gr_res_type.SuspendLayout();
            this.gr_how_to.SuspendLayout();
            this.gr_system.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_bar
            // 
            this.menu_bar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_list,
            this.build_list,
            this.options_list,
            this.help_list});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(773, 28);
            this.menu_bar.TabIndex = 0;
            this.menu_bar.Text = "menuStrip1";
            // 
            // file_list
            // 
            this.file_list.AutoSize = false;
            this.file_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_project_but,
            this.toolStripSeparator1,
            this.open_project_but,
            this.save_project_but,
            this.saveas_project_but,
            this.toolStripSeparator2,
            this.latest_project_but,
            this.toolStripSeparator3,
            this.quit_but});
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(57, 24);
            this.file_list.Text = "&Файл";
            // 
            // new_project_but
            // 
            this.new_project_but.Image = global::W2W_SDK.Properties.Resources._new;
            this.new_project_but.Name = "new_project_but";
            this.new_project_but.Size = new System.Drawing.Size(218, 24);
            this.new_project_but.Text = "&Новый проект";
            this.new_project_but.Click += new System.EventHandler(this.new_project_but_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // open_project_but
            // 
            this.open_project_but.Image = global::W2W_SDK.Properties.Resources.folder;
            this.open_project_but.Name = "open_project_but";
            this.open_project_but.Size = new System.Drawing.Size(218, 24);
            this.open_project_but.Text = "О&ткрыть проект";
            this.open_project_but.Click += new System.EventHandler(this.open_project_but_Click);
            // 
            // save_project_but
            // 
            this.save_project_but.Enabled = false;
            this.save_project_but.Image = global::W2W_SDK.Properties.Resources.save;
            this.save_project_but.Name = "save_project_but";
            this.save_project_but.Size = new System.Drawing.Size(218, 24);
            this.save_project_but.Text = "&Сохранить";
            this.save_project_but.Click += new System.EventHandler(this.save_project_but_Click);
            // 
            // saveas_project_but
            // 
            this.saveas_project_but.Enabled = false;
            this.saveas_project_but.Image = global::W2W_SDK.Properties.Resources.save;
            this.saveas_project_but.Name = "saveas_project_but";
            this.saveas_project_but.Size = new System.Drawing.Size(218, 24);
            this.saveas_project_but.Text = "&Сохранить как";
            this.saveas_project_but.Click += new System.EventHandler(this.saveas_project_but_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // latest_project_but
            // 
            this.latest_project_but.AutoSize = false;
            this.latest_project_but.Image = global::W2W_SDK.Properties.Resources.clock;
            this.latest_project_but.Name = "latest_project_but";
            this.latest_project_but.Size = new System.Drawing.Size(218, 24);
            this.latest_project_but.Text = "&Последние проекты";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // quit_but
            // 
            this.quit_but.Image = global::W2W_SDK.Properties.Resources.quit;
            this.quit_but.Name = "quit_but";
            this.quit_but.Size = new System.Drawing.Size(218, 24);
            this.quit_but.Text = "&Выйти";
            this.quit_but.Click += new System.EventHandler(this.quit_but_Click);
            // 
            // build_list
            // 
            this.build_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compile_but,
            this.toolStripSeparator4,
            this.options_but});
            this.build_list.Name = "build_list";
            this.build_list.Size = new System.Drawing.Size(72, 24);
            this.build_list.Text = "&Сброка";
            // 
            // compile_but
            // 
            this.compile_but.Enabled = false;
            this.compile_but.Image = global::W2W_SDK.Properties.Resources.monitor;
            this.compile_but.Name = "compile_but";
            this.compile_but.Size = new System.Drawing.Size(189, 24);
            this.compile_but.Text = "&Сборка проекта";
            this.compile_but.Click += new System.EventHandler(this.compile_but_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // options_but
            // 
            this.options_but.Enabled = false;
            this.options_but.Image = global::W2W_SDK.Properties.Resources.prefs;
            this.options_but.Name = "options_but";
            this.options_but.Size = new System.Drawing.Size(189, 24);
            this.options_but.Text = "&Настройки";
            this.options_but.Click += new System.EventHandler(this.options_but_Click);
            // 
            // options_list
            // 
            this.options_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_compile_but,
            this.toolStripSeparator5,
            this.opt_ui_but,
            this.opt_update_but});
            this.options_list.Name = "options_list";
            this.options_list.Size = new System.Drawing.Size(96, 24);
            this.options_list.Text = "&Настройки";
            // 
            // opt_compile_but
            // 
            this.opt_compile_but.Image = global::W2W_SDK.Properties.Resources.code;
            this.opt_compile_but.Name = "opt_compile_but";
            this.opt_compile_but.Size = new System.Drawing.Size(166, 24);
            this.opt_compile_but.Text = "&Компилятор";
            this.opt_compile_but.Click += new System.EventHandler(this.opt_compile_but_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // opt_ui_but
            // 
            this.opt_ui_but.Image = global::W2W_SDK.Properties.Resources.ui;
            this.opt_ui_but.Name = "opt_ui_but";
            this.opt_ui_but.Size = new System.Drawing.Size(166, 24);
            this.opt_ui_but.Text = "И&нтерфейс";
            this.opt_ui_but.Click += new System.EventHandler(this.opt_ui_but_Click);
            // 
            // opt_update_but
            // 
            this.opt_update_but.Image = global::W2W_SDK.Properties.Resources.update;
            this.opt_update_but.Name = "opt_update_but";
            this.opt_update_but.Size = new System.Drawing.Size(166, 24);
            this.opt_update_but.Text = "О&бновление";
            this.opt_update_but.Click += new System.EventHandler(this.opt_update_but_Click);
            // 
            // help_list
            // 
            this.help_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_but,
            this.toolStripSeparator6,
            this.docs_but,
            this.toolStripSeparator7,
            this.soft_site_but,
            this.dev_site_but,
            this.toolStripSeparator8,
            this.gh_but});
            this.help_list.Name = "help_list";
            this.help_list.Size = new System.Drawing.Size(81, 24);
            this.help_list.Text = "&Помощь";
            // 
            // about_but
            // 
            this.about_but.Image = global::W2W_SDK.Properties.Resources.info;
            this.about_but.Name = "about_but";
            this.about_but.Size = new System.Drawing.Size(211, 24);
            this.about_but.Text = "О &программе";
            this.about_but.Click += new System.EventHandler(this.about_but_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(208, 6);
            // 
            // docs_but
            // 
            this.docs_but.Image = global::W2W_SDK.Properties.Resources.help;
            this.docs_but.Name = "docs_but";
            this.docs_but.Size = new System.Drawing.Size(211, 24);
            this.docs_but.Text = "&Справка";
            this.docs_but.Click += new System.EventHandler(this.docs_but_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(208, 6);
            // 
            // soft_site_but
            // 
            this.soft_site_but.Image = global::W2W_SDK.Properties.Resources.web;
            this.soft_site_but.Name = "soft_site_but";
            this.soft_site_but.Size = new System.Drawing.Size(211, 24);
            this.soft_site_but.Text = "&Сайт продукта";
            this.soft_site_but.Click += new System.EventHandler(this.soft_site_but_Click);
            // 
            // dev_site_but
            // 
            this.dev_site_but.Image = global::W2W_SDK.Properties.Resources.web;
            this.dev_site_but.Name = "dev_site_but";
            this.dev_site_but.Size = new System.Drawing.Size(211, 24);
            this.dev_site_but.Text = "&Сайт разработчика";
            this.dev_site_but.Click += new System.EventHandler(this.dev_site_but_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(208, 6);
            // 
            // gh_but
            // 
            this.gh_but.Image = global::W2W_SDK.Properties.Resources.github;
            this.gh_but.Name = "gh_but";
            this.gh_but.Size = new System.Drawing.Size(211, 24);
            this.gh_but.Text = "&Git Hub";
            this.gh_but.Click += new System.EventHandler(this.gh_but_Click);
            // 
            // state_bar
            // 
            this.state_bar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.state_progress});
            this.state_bar.Location = new System.Drawing.Point(0, 620);
            this.state_bar.Name = "state_bar";
            this.state_bar.Size = new System.Drawing.Size(773, 22);
            this.state_bar.TabIndex = 1;
            this.state_bar.Text = "statusStrip1";
            // 
            // state_progress
            // 
            this.state_progress.Name = "state_progress";
            this.state_progress.Size = new System.Drawing.Size(100, 16);
            // 
            // open_project_dialog
            // 
            this.open_project_dialog.Description = "Выберите папку проекта";
            this.open_project_dialog.ShowNewFolderButton = false;
            // 
            // save_project_dialog
            // 
            this.save_project_dialog.Description = "Выберите папку для сохранения проекта";
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.n_open_but,
            this.n_hide_but,
            this.toolStripSeparator10,
            this.n_quit_but});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(124, 76);
            // 
            // n_open_but
            // 
            this.n_open_but.Name = "n_open_but";
            this.n_open_but.Size = new System.Drawing.Size(123, 22);
            this.n_open_but.Text = "Открыть";
            this.n_open_but.Click += new System.EventHandler(this.n_open_but_Click);
            // 
            // n_hide_but
            // 
            this.n_hide_but.Name = "n_hide_but";
            this.n_hide_but.Size = new System.Drawing.Size(123, 22);
            this.n_hide_but.Text = "Свернуть";
            this.n_hide_but.Click += new System.EventHandler(this.n_hide_but_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(120, 6);
            // 
            // n_quit_but
            // 
            this.n_quit_but.Name = "n_quit_but";
            this.n_quit_but.Size = new System.Drawing.Size(123, 22);
            this.n_quit_but.Text = "Выход";
            this.n_quit_but.Click += new System.EventHandler(this.n_quit_but_Click);
            // 
            // form_container
            // 
            this.form_container.Controls.Add(this.project_tabs);
            this.form_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_container.Location = new System.Drawing.Point(0, 28);
            this.form_container.Name = "form_container";
            this.form_container.Size = new System.Drawing.Size(773, 592);
            this.form_container.TabIndex = 2;
            // 
            // project_tabs
            // 
            this.project_tabs.Controls.Add(this.project_options);
            this.project_tabs.Controls.Add(this.tabPage2);
            this.project_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_tabs.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.project_tabs.Location = new System.Drawing.Point(0, 0);
            this.project_tabs.Name = "project_tabs";
            this.project_tabs.SelectedIndex = 0;
            this.project_tabs.Size = new System.Drawing.Size(773, 592);
            this.project_tabs.TabIndex = 0;
            this.project_tabs.Visible = false;
            // 
            // project_options
            // 
            this.project_options.Controls.Add(this.gr_prj_icon);
            this.project_options.Controls.Add(this.gr_prj_trademark);
            this.project_options.Controls.Add(this.gr_prj_copyright);
            this.project_options.Controls.Add(this.gr_prj_product);
            this.project_options.Controls.Add(this.gr_prj_desc);
            this.project_options.Controls.Add(this.gr_prj_version);
            this.project_options.Controls.Add(this.gr_dev_name);
            this.project_options.Controls.Add(this.gr_prj_name);
            this.project_options.Location = new System.Drawing.Point(4, 26);
            this.project_options.Name = "project_options";
            this.project_options.Padding = new System.Windows.Forms.Padding(3);
            this.project_options.Size = new System.Drawing.Size(765, 562);
            this.project_options.TabIndex = 0;
            this.project_options.Text = "Настройки проекта";
            this.project_options.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gr_system);
            this.tabPage2.Controls.Add(this.gr_how_to);
            this.tabPage2.Controls.Add(this.gr_res_type);
            this.tabPage2.Controls.Add(this.gr_app_type);
            this.tabPage2.Controls.Add(this.gr_type);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Компиляция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // build_project_dialog
            // 
            this.build_project_dialog.Description = "Выберите папку для сборки проекта";
            // 
            // gr_prj_name
            // 
            this.gr_prj_name.Controls.Add(this.prj_name_text);
            this.gr_prj_name.Location = new System.Drawing.Point(8, 6);
            this.gr_prj_name.Name = "gr_prj_name";
            this.gr_prj_name.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_name.TabIndex = 0;
            this.gr_prj_name.TabStop = false;
            this.gr_prj_name.Text = "Введите имя проекта";
            // 
            // prj_name_text
            // 
            this.prj_name_text.Location = new System.Drawing.Point(6, 24);
            this.prj_name_text.MaxLength = 250;
            this.prj_name_text.Name = "prj_name_text";
            this.prj_name_text.Size = new System.Drawing.Size(737, 25);
            this.prj_name_text.TabIndex = 1;
            // 
            // gr_dev_name
            // 
            this.gr_dev_name.Controls.Add(this.prj_developer_text);
            this.gr_dev_name.Location = new System.Drawing.Point(8, 75);
            this.gr_dev_name.Name = "gr_dev_name";
            this.gr_dev_name.Size = new System.Drawing.Size(749, 63);
            this.gr_dev_name.TabIndex = 2;
            this.gr_dev_name.TabStop = false;
            this.gr_dev_name.Text = "Введите имя разработчика";
            // 
            // prj_developer_text
            // 
            this.prj_developer_text.Location = new System.Drawing.Point(6, 24);
            this.prj_developer_text.MaxLength = 250;
            this.prj_developer_text.Name = "prj_developer_text";
            this.prj_developer_text.Size = new System.Drawing.Size(737, 25);
            this.prj_developer_text.TabIndex = 1;
            // 
            // gr_prj_version
            // 
            this.gr_prj_version.Controls.Add(this.prj_version_text);
            this.gr_prj_version.Location = new System.Drawing.Point(8, 144);
            this.gr_prj_version.Name = "gr_prj_version";
            this.gr_prj_version.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_version.TabIndex = 3;
            this.gr_prj_version.TabStop = false;
            this.gr_prj_version.Text = "Введите версию программы";
            // 
            // gr_prj_desc
            // 
            this.gr_prj_desc.Controls.Add(this.prj_desc_text);
            this.gr_prj_desc.Location = new System.Drawing.Point(8, 213);
            this.gr_prj_desc.Name = "gr_prj_desc";
            this.gr_prj_desc.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_desc.TabIndex = 4;
            this.gr_prj_desc.TabStop = false;
            this.gr_prj_desc.Text = "Введите описание программы";
            // 
            // prj_desc_text
            // 
            this.prj_desc_text.Location = new System.Drawing.Point(6, 24);
            this.prj_desc_text.MaxLength = 250;
            this.prj_desc_text.Name = "prj_desc_text";
            this.prj_desc_text.Size = new System.Drawing.Size(737, 25);
            this.prj_desc_text.TabIndex = 1;
            // 
            // gr_prj_product
            // 
            this.gr_prj_product.Controls.Add(this.prj_product_text);
            this.gr_prj_product.Location = new System.Drawing.Point(8, 282);
            this.gr_prj_product.Name = "gr_prj_product";
            this.gr_prj_product.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_product.TabIndex = 5;
            this.gr_prj_product.TabStop = false;
            this.gr_prj_product.Text = "Введите название продукта";
            // 
            // prj_product_text
            // 
            this.prj_product_text.Location = new System.Drawing.Point(6, 24);
            this.prj_product_text.MaxLength = 250;
            this.prj_product_text.Name = "prj_product_text";
            this.prj_product_text.Size = new System.Drawing.Size(737, 25);
            this.prj_product_text.TabIndex = 1;
            // 
            // gr_prj_copyright
            // 
            this.gr_prj_copyright.Controls.Add(this.prj_copyright_text);
            this.gr_prj_copyright.Location = new System.Drawing.Point(8, 351);
            this.gr_prj_copyright.Name = "gr_prj_copyright";
            this.gr_prj_copyright.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_copyright.TabIndex = 6;
            this.gr_prj_copyright.TabStop = false;
            this.gr_prj_copyright.Text = "Введите копирайт программы";
            // 
            // prj_copyright_text
            // 
            this.prj_copyright_text.Location = new System.Drawing.Point(6, 24);
            this.prj_copyright_text.MaxLength = 250;
            this.prj_copyright_text.Name = "prj_copyright_text";
            this.prj_copyright_text.Size = new System.Drawing.Size(737, 25);
            this.prj_copyright_text.TabIndex = 1;
            // 
            // gr_prj_trademark
            // 
            this.gr_prj_trademark.Controls.Add(this.prj_trademark_text);
            this.gr_prj_trademark.Location = new System.Drawing.Point(8, 420);
            this.gr_prj_trademark.Name = "gr_prj_trademark";
            this.gr_prj_trademark.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_trademark.TabIndex = 7;
            this.gr_prj_trademark.TabStop = false;
            this.gr_prj_trademark.Text = "Введите торговую марку";
            // 
            // prj_trademark_text
            // 
            this.prj_trademark_text.Location = new System.Drawing.Point(6, 24);
            this.prj_trademark_text.MaxLength = 250;
            this.prj_trademark_text.Name = "prj_trademark_text";
            this.prj_trademark_text.Size = new System.Drawing.Size(737, 25);
            this.prj_trademark_text.TabIndex = 1;
            // 
            // prj_version_text
            // 
            this.prj_version_text.Location = new System.Drawing.Point(6, 25);
            this.prj_version_text.Mask = "9.9.9.9";
            this.prj_version_text.Name = "prj_version_text";
            this.prj_version_text.Size = new System.Drawing.Size(737, 25);
            this.prj_version_text.TabIndex = 8;
            // 
            // gr_prj_icon
            // 
            this.gr_prj_icon.Controls.Add(this.prj_icon_but);
            this.gr_prj_icon.Controls.Add(this.prj_icon_text);
            this.gr_prj_icon.Location = new System.Drawing.Point(8, 489);
            this.gr_prj_icon.Name = "gr_prj_icon";
            this.gr_prj_icon.Size = new System.Drawing.Size(749, 63);
            this.gr_prj_icon.TabIndex = 8;
            this.gr_prj_icon.TabStop = false;
            this.gr_prj_icon.Text = "Выберите иконку проекта";
            // 
            // prj_icon_but
            // 
            this.prj_icon_but.Location = new System.Drawing.Point(668, 23);
            this.prj_icon_but.Name = "prj_icon_but";
            this.prj_icon_but.Size = new System.Drawing.Size(75, 27);
            this.prj_icon_but.TabIndex = 3;
            this.prj_icon_but.Text = "Обзор";
            this.prj_icon_but.UseVisualStyleBackColor = true;
            // 
            // prj_icon_text
            // 
            this.prj_icon_text.Enabled = false;
            this.prj_icon_text.Location = new System.Drawing.Point(6, 24);
            this.prj_icon_text.Name = "prj_icon_text";
            this.prj_icon_text.Size = new System.Drawing.Size(656, 25);
            this.prj_icon_text.TabIndex = 2;
            // 
            // gr_type
            // 
            this.gr_type.Controls.Add(this.compile_type);
            this.gr_type.Location = new System.Drawing.Point(8, 6);
            this.gr_type.Name = "gr_type";
            this.gr_type.Size = new System.Drawing.Size(749, 63);
            this.gr_type.TabIndex = 1;
            this.gr_type.TabStop = false;
            this.gr_type.Text = "Выберите тип компиляции";
            // 
            // compile_type
            // 
            this.compile_type.FormattingEnabled = true;
            this.compile_type.Items.AddRange(new object[] {
            "Компиляция с использованием .bat файла",
            "Компиляция с использованием .exe файла"});
            this.compile_type.Location = new System.Drawing.Point(6, 24);
            this.compile_type.Name = "compile_type";
            this.compile_type.Size = new System.Drawing.Size(737, 25);
            this.compile_type.TabIndex = 2;
            // 
            // gr_app_type
            // 
            this.gr_app_type.Controls.Add(this.app_type);
            this.gr_app_type.Location = new System.Drawing.Point(8, 75);
            this.gr_app_type.Name = "gr_app_type";
            this.gr_app_type.Size = new System.Drawing.Size(749, 63);
            this.gr_app_type.TabIndex = 3;
            this.gr_app_type.TabStop = false;
            this.gr_app_type.Text = "Выберите тип приложения";
            // 
            // app_type
            // 
            this.app_type.FormattingEnabled = true;
            this.app_type.Items.AddRange(new object[] {
            "Полноэкранное приложение (без возможности смены режима)",
            "Оконное приложение (без возможности смены режима)",
            "Приложение с возможностью смены режима"});
            this.app_type.Location = new System.Drawing.Point(6, 24);
            this.app_type.Name = "app_type";
            this.app_type.Size = new System.Drawing.Size(737, 25);
            this.app_type.TabIndex = 2;
            // 
            // gr_res_type
            // 
            this.gr_res_type.Controls.Add(this.resource_type);
            this.gr_res_type.Location = new System.Drawing.Point(8, 144);
            this.gr_res_type.Name = "gr_res_type";
            this.gr_res_type.Size = new System.Drawing.Size(749, 63);
            this.gr_res_type.TabIndex = 4;
            this.gr_res_type.TabStop = false;
            this.gr_res_type.Text = "Выберите тип хранения ресурсов";
            // 
            // resource_type
            // 
            this.resource_type.FormattingEnabled = true;
            this.resource_type.Items.AddRange(new object[] {
            "Открытые ресурсы",
            "Компилированные ресурсы",
            "Компилированные зашифрованные ресурсы"});
            this.resource_type.Location = new System.Drawing.Point(6, 24);
            this.resource_type.Name = "resource_type";
            this.resource_type.Size = new System.Drawing.Size(737, 25);
            this.resource_type.TabIndex = 2;
            // 
            // gr_how_to
            // 
            this.gr_how_to.Controls.Add(this.HowToLabel);
            this.gr_how_to.Location = new System.Drawing.Point(8, 213);
            this.gr_how_to.Name = "gr_how_to";
            this.gr_how_to.Size = new System.Drawing.Size(749, 76);
            this.gr_how_to.TabIndex = 5;
            this.gr_how_to.TabStop = false;
            this.gr_how_to.Text = "Как собрать проект?";
            // 
            // HowToLabel
            // 
            this.HowToLabel.Location = new System.Drawing.Point(6, 21);
            this.HowToLabel.Name = "HowToLabel";
            this.HowToLabel.Size = new System.Drawing.Size(737, 47);
            this.HowToLabel.TabIndex = 0;
            this.HowToLabel.Text = "Чтобы создать ваше приложение для использование на Windows - выберите пункт в мен" +
    "ю \"Сборка\", а затем элемент \"Сборка проекта\". После чего, ваш проект будет готов" +
    " к использованию.";
            // 
            // gr_system
            // 
            this.gr_system.Controls.Add(this.SystemLabel);
            this.gr_system.Location = new System.Drawing.Point(8, 295);
            this.gr_system.Name = "gr_system";
            this.gr_system.Size = new System.Drawing.Size(749, 86);
            this.gr_system.TabIndex = 6;
            this.gr_system.TabStop = false;
            this.gr_system.Text = "Требования к системе";
            // 
            // SystemLabel
            // 
            this.SystemLabel.ForeColor = System.Drawing.Color.Maroon;
            this.SystemLabel.Location = new System.Drawing.Point(6, 21);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(737, 55);
            this.SystemLabel.TabIndex = 0;
            this.SystemLabel.Text = resources.GetString("SystemLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(773, 642);
            this.Controls.Add(this.form_container);
            this.Controls.Add(this.state_bar);
            this.Controls.Add(this.menu_bar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::W2W_SDK.Properties.Settings.Default, "window_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::W2W_SDK.Properties.Settings.Default.window_location;
            this.MainMenuStrip = this.menu_bar;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Web2Win SDK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.state_bar.ResumeLayout(false);
            this.state_bar.PerformLayout();
            this.notify_menu.ResumeLayout(false);
            this.form_container.ResumeLayout(false);
            this.project_tabs.ResumeLayout(false);
            this.project_options.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gr_prj_name.ResumeLayout(false);
            this.gr_prj_name.PerformLayout();
            this.gr_dev_name.ResumeLayout(false);
            this.gr_dev_name.PerformLayout();
            this.gr_prj_version.ResumeLayout(false);
            this.gr_prj_version.PerformLayout();
            this.gr_prj_desc.ResumeLayout(false);
            this.gr_prj_desc.PerformLayout();
            this.gr_prj_product.ResumeLayout(false);
            this.gr_prj_product.PerformLayout();
            this.gr_prj_copyright.ResumeLayout(false);
            this.gr_prj_copyright.PerformLayout();
            this.gr_prj_trademark.ResumeLayout(false);
            this.gr_prj_trademark.PerformLayout();
            this.gr_prj_icon.ResumeLayout(false);
            this.gr_prj_icon.PerformLayout();
            this.gr_type.ResumeLayout(false);
            this.gr_app_type.ResumeLayout(false);
            this.gr_res_type.ResumeLayout(false);
            this.gr_how_to.ResumeLayout(false);
            this.gr_system.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.StatusStrip state_bar;
        private System.Windows.Forms.ToolStripMenuItem file_list;
        private System.Windows.Forms.ToolStripMenuItem build_list;
        private System.Windows.Forms.ToolStripMenuItem options_list;
        private System.Windows.Forms.ToolStripMenuItem help_list;
        private System.Windows.Forms.ToolStripMenuItem new_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem open_project_but;
        private System.Windows.Forms.ToolStripMenuItem save_project_but;
        private System.Windows.Forms.ToolStripMenuItem saveas_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem latest_project_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quit_but;
        private System.Windows.Forms.ToolStripMenuItem compile_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem options_but;
        private System.Windows.Forms.ToolStripMenuItem opt_compile_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem opt_ui_but;
        private System.Windows.Forms.ToolStripMenuItem opt_update_but;
        private System.Windows.Forms.ToolStripMenuItem about_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem docs_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem soft_site_but;
        private System.Windows.Forms.ToolStripMenuItem dev_site_but;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem gh_but;
        private System.Windows.Forms.FolderBrowserDialog open_project_dialog;
        private System.Windows.Forms.FolderBrowserDialog save_project_dialog;
        private System.Windows.Forms.ToolStripProgressBar state_progress;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel form_container;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem n_open_but;
        private System.Windows.Forms.ToolStripMenuItem n_hide_but;
        private System.Windows.Forms.ToolStripMenuItem n_quit_but;
        private System.Windows.Forms.TabControl project_tabs;
        private System.Windows.Forms.TabPage project_options;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.FolderBrowserDialog build_project_dialog;
        private System.Windows.Forms.GroupBox gr_prj_name;
        private System.Windows.Forms.TextBox prj_name_text;
        private System.Windows.Forms.GroupBox gr_dev_name;
        private System.Windows.Forms.TextBox prj_developer_text;
        private System.Windows.Forms.GroupBox gr_prj_product;
        private System.Windows.Forms.TextBox prj_product_text;
        private System.Windows.Forms.GroupBox gr_prj_desc;
        private System.Windows.Forms.TextBox prj_desc_text;
        private System.Windows.Forms.GroupBox gr_prj_version;
        private System.Windows.Forms.GroupBox gr_prj_trademark;
        private System.Windows.Forms.TextBox prj_trademark_text;
        private System.Windows.Forms.GroupBox gr_prj_copyright;
        private System.Windows.Forms.TextBox prj_copyright_text;
        private System.Windows.Forms.MaskedTextBox prj_version_text;
        private System.Windows.Forms.GroupBox gr_prj_icon;
        private System.Windows.Forms.Button prj_icon_but;
        private System.Windows.Forms.TextBox prj_icon_text;
        private System.Windows.Forms.GroupBox gr_type;
        private System.Windows.Forms.ComboBox compile_type;
        private System.Windows.Forms.GroupBox gr_res_type;
        private System.Windows.Forms.ComboBox resource_type;
        private System.Windows.Forms.GroupBox gr_app_type;
        private System.Windows.Forms.ComboBox app_type;
        private System.Windows.Forms.GroupBox gr_how_to;
        private System.Windows.Forms.GroupBox gr_system;
        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.Label HowToLabel;

    }
}

