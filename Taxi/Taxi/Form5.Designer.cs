namespace Taxi
{
    partial class F5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label регистрационный_номерLabel;
            System.Windows.Forms.Label номер_кузоваLabel;
            System.Windows.Forms.Label номер_двигателяLabel;
            System.Windows.Forms.Label год_выпускаLabel;
            System.Windows.Forms.Label пробегLabel;
            System.Windows.Forms.Label дата_последнего_ТОLabel;
            System.Windows.Forms.Label код_сотрудника_механикаLabel;
            System.Windows.Forms.Label код_маркиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F5));
            this.taxiDataSet = new Taxi.TaxiDataSet();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Taxi.TaxiDataSetTableAdapters.АвтомобилиTableAdapter();
            this.tableAdapterManager = new Taxi.TaxiDataSetTableAdapters.TableAdapterManager();
            this.марка_автомобиляTableAdapter = new Taxi.TaxiDataSetTableAdapters.Марка_автомобиляTableAdapter();
            this.автомобилиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.автомобилиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_кузоваTextBox = new System.Windows.Forms.TextBox();
            this.номер_двигателяTextBox = new System.Windows.Forms.TextBox();
            this.пробегTextBox = new System.Windows.Forms.TextBox();
            this.дата_последнего_ТОDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.марка_автомобиляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_маркиComboBox1 = new System.Windows.Forms.ComboBox();
            this.код_сотрудника_механикаComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Taxi.TaxiDataSetTableAdapters.СотрудникиTableAdapter();
            this.год_выпускаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.регистрационный_номерTextBox = new System.Windows.Forms.TextBox();
            регистрационный_номерLabel = new System.Windows.Forms.Label();
            номер_кузоваLabel = new System.Windows.Forms.Label();
            номер_двигателяLabel = new System.Windows.Forms.Label();
            год_выпускаLabel = new System.Windows.Forms.Label();
            пробегLabel = new System.Windows.Forms.Label();
            дата_последнего_ТОLabel = new System.Windows.Forms.Label();
            код_сотрудника_механикаLabel = new System.Windows.Forms.Label();
            код_маркиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingNavigator)).BeginInit();
            this.автомобилиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // регистрационный_номерLabel
            // 
            регистрационный_номерLabel.AutoSize = true;
            регистрационный_номерLabel.Location = new System.Drawing.Point(21, 74);
            регистрационный_номерLabel.Name = "регистрационный_номерLabel";
            регистрационный_номерLabel.Size = new System.Drawing.Size(172, 16);
            регистрационный_номерLabel.TabIndex = 3;
            регистрационный_номерLabel.Text = "Регистрационный номер:";
            // 
            // номер_кузоваLabel
            // 
            номер_кузоваLabel.AutoSize = true;
            номер_кузоваLabel.Location = new System.Drawing.Point(20, 105);
            номер_кузоваLabel.Name = "номер_кузоваLabel";
            номер_кузоваLabel.Size = new System.Drawing.Size(103, 16);
            номер_кузоваLabel.TabIndex = 5;
            номер_кузоваLabel.Text = "Номер кузова:";
            // 
            // номер_двигателяLabel
            // 
            номер_двигателяLabel.AutoSize = true;
            номер_двигателяLabel.Location = new System.Drawing.Point(21, 140);
            номер_двигателяLabel.Name = "номер_двигателяLabel";
            номер_двигателяLabel.Size = new System.Drawing.Size(124, 16);
            номер_двигателяLabel.TabIndex = 7;
            номер_двигателяLabel.Text = "Номер двигателя:";
            // 
            // год_выпускаLabel
            // 
            год_выпускаLabel.AutoSize = true;
            год_выпускаLabel.Location = new System.Drawing.Point(21, 178);
            год_выпускаLabel.Name = "год_выпускаLabel";
            год_выпускаLabel.Size = new System.Drawing.Size(91, 16);
            год_выпускаLabel.TabIndex = 9;
            год_выпускаLabel.Text = "Год выпуска:";
            // 
            // пробегLabel
            // 
            пробегLabel.AutoSize = true;
            пробегLabel.Location = new System.Drawing.Point(21, 215);
            пробегLabel.Name = "пробегLabel";
            пробегLabel.Size = new System.Drawing.Size(58, 16);
            пробегLabel.TabIndex = 11;
            пробегLabel.Text = "Пробег:";
            // 
            // дата_последнего_ТОLabel
            // 
            дата_последнего_ТОLabel.AutoSize = true;
            дата_последнего_ТОLabel.Location = new System.Drawing.Point(21, 257);
            дата_последнего_ТОLabel.Name = "дата_последнего_ТОLabel";
            дата_последнего_ТОLabel.Size = new System.Drawing.Size(144, 16);
            дата_последнего_ТОLabel.TabIndex = 13;
            дата_последнего_ТОLabel.Text = "Дата последнего ТО:";
            // 
            // код_сотрудника_механикаLabel
            // 
            код_сотрудника_механикаLabel.AutoSize = true;
            код_сотрудника_механикаLabel.Location = new System.Drawing.Point(21, 295);
            код_сотрудника_механикаLabel.Name = "код_сотрудника_механикаLabel";
            код_сотрудника_механикаLabel.Size = new System.Drawing.Size(180, 16);
            код_сотрудника_механикаLabel.TabIndex = 15;
            код_сотрудника_механикаLabel.Text = "Код сотрудника-механика:";
            // 
            // код_маркиLabel
            // 
            код_маркиLabel.AutoSize = true;
            код_маркиLabel.Location = new System.Drawing.Point(20, 44);
            код_маркиLabel.Name = "код_маркиLabel";
            код_маркиLabel.Size = new System.Drawing.Size(77, 16);
            код_маркиLabel.TabIndex = 16;
            код_маркиLabel.Text = "Код марки:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.taxiDataSet;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Taxi.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = this.автомобилиTableAdapter;
            this.tableAdapterManager.ВызовыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марка_автомобиляTableAdapter = this.марка_автомобиляTableAdapter;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = null;
            // 
            // марка_автомобиляTableAdapter
            // 
            this.марка_автомобиляTableAdapter.ClearBeforeFill = true;
            // 
            // автомобилиBindingNavigator
            // 
            this.автомобилиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автомобилиBindingNavigator.BindingSource = this.автомобилиBindingSource;
            this.автомобилиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автомобилиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автомобилиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.автомобилиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.автомобилиBindingNavigatorSaveItem});
            this.автомобилиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автомобилиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автомобилиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автомобилиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автомобилиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автомобилиBindingNavigator.Name = "автомобилиBindingNavigator";
            this.автомобилиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автомобилиBindingNavigator.Size = new System.Drawing.Size(472, 27);
            this.автомобилиBindingNavigator.TabIndex = 0;
            this.автомобилиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // автомобилиBindingNavigatorSaveItem
            // 
            this.автомобилиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автомобилиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автомобилиBindingNavigatorSaveItem.Image")));
            this.автомобилиBindingNavigatorSaveItem.Name = "автомобилиBindingNavigatorSaveItem";
            this.автомобилиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.автомобилиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автомобилиBindingNavigatorSaveItem.Click += new System.EventHandler(this.автомобилиBindingNavigatorSaveItem_Click);
            // 
            // номер_кузоваTextBox
            // 
            this.номер_кузоваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Номер кузова", true));
            this.номер_кузоваTextBox.Location = new System.Drawing.Point(208, 105);
            this.номер_кузоваTextBox.Name = "номер_кузоваTextBox";
            this.номер_кузоваTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_кузоваTextBox.TabIndex = 6;
            // 
            // номер_двигателяTextBox
            // 
            this.номер_двигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Номер двигателя", true));
            this.номер_двигателяTextBox.Location = new System.Drawing.Point(208, 140);
            this.номер_двигателяTextBox.Name = "номер_двигателяTextBox";
            this.номер_двигателяTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_двигателяTextBox.TabIndex = 8;
            // 
            // пробегTextBox
            // 
            this.пробегTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Пробег", true));
            this.пробегTextBox.Location = new System.Drawing.Point(208, 212);
            this.пробегTextBox.Name = "пробегTextBox";
            this.пробегTextBox.Size = new System.Drawing.Size(200, 22);
            this.пробегTextBox.TabIndex = 12;
            // 
            // дата_последнего_ТОDateTimePicker
            // 
            this.дата_последнего_ТОDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.автомобилиBindingSource, "Дата последнего ТО", true));
            this.дата_последнего_ТОDateTimePicker.Location = new System.Drawing.Point(208, 251);
            this.дата_последнего_ТОDateTimePicker.Name = "дата_последнего_ТОDateTimePicker";
            this.дата_последнего_ТОDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_последнего_ТОDateTimePicker.TabIndex = 14;
            // 
            // марка_автомобиляBindingSource
            // 
            this.марка_автомобиляBindingSource.DataMember = "Марка автомобиля";
            this.марка_автомобиляBindingSource.DataSource = this.taxiDataSet;
            // 
            // код_маркиComboBox1
            // 
            this.код_маркиComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код марки", true));
            this.код_маркиComboBox1.DataSource = this.марка_автомобиляBindingSource;
            this.код_маркиComboBox1.DisplayMember = "Код марки";
            this.код_маркиComboBox1.FormattingEnabled = true;
            this.код_маркиComboBox1.Location = new System.Drawing.Point(208, 36);
            this.код_маркиComboBox1.Name = "код_маркиComboBox1";
            this.код_маркиComboBox1.Size = new System.Drawing.Size(200, 24);
            this.код_маркиComboBox1.TabIndex = 18;
            // 
            // код_сотрудника_механикаComboBox
            // 
            this.код_сотрудника_механикаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код сотрудника-механика", true));
            this.код_сотрудника_механикаComboBox.DataSource = this.сотрудникиBindingSource;
            this.код_сотрудника_механикаComboBox.DisplayMember = "Код сотрудника";
            this.код_сотрудника_механикаComboBox.FormattingEnabled = true;
            this.код_сотрудника_механикаComboBox.Location = new System.Drawing.Point(208, 292);
            this.код_сотрудника_механикаComboBox.Name = "код_сотрудника_механикаComboBox";
            this.код_сотрудника_механикаComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_сотрудника_механикаComboBox.TabIndex = 19;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.taxiDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // год_выпускаMaskedTextBox
            // 
            this.год_выпускаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Год выпуска", true));
            this.год_выпускаMaskedTextBox.Location = new System.Drawing.Point(208, 178);
            this.год_выпускаMaskedTextBox.Mask = "0000";
            this.год_выпускаMaskedTextBox.Name = "год_выпускаMaskedTextBox";
            this.год_выпускаMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.год_выпускаMaskedTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // регистрационный_номерTextBox
            // 
            this.регистрационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Регистрационный номер", true));
            this.регистрационный_номерTextBox.Location = new System.Drawing.Point(208, 66);
            this.регистрационный_номерTextBox.Name = "регистрационный_номерTextBox";
            this.регистрационный_номерTextBox.Size = new System.Drawing.Size(200, 22);
            this.регистрационный_номерTextBox.TabIndex = 23;
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(472, 461);
            this.Controls.Add(this.регистрационный_номерTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.год_выпускаMaskedTextBox);
            this.Controls.Add(this.код_сотрудника_механикаComboBox);
            this.Controls.Add(this.код_маркиComboBox1);
            this.Controls.Add(код_маркиLabel);
            this.Controls.Add(код_сотрудника_механикаLabel);
            this.Controls.Add(дата_последнего_ТОLabel);
            this.Controls.Add(this.дата_последнего_ТОDateTimePicker);
            this.Controls.Add(пробегLabel);
            this.Controls.Add(this.пробегTextBox);
            this.Controls.Add(год_выпускаLabel);
            this.Controls.Add(номер_двигателяLabel);
            this.Controls.Add(this.номер_двигателяTextBox);
            this.Controls.Add(номер_кузоваLabel);
            this.Controls.Add(this.номер_кузоваTextBox);
            this.Controls.Add(регистрационный_номерLabel);
            this.Controls.Add(this.автомобилиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F5";
            this.Text = "Добавим подробную информацию";
            this.Load += new System.EventHandler(this.F5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingNavigator)).EndInit();
            this.автомобилиBindingNavigator.ResumeLayout(false);
            this.автомобилиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private TaxiDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автомобилиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton автомобилиBindingNavigatorSaveItem;
        private TaxiDataSetTableAdapters.Марка_автомобиляTableAdapter марка_автомобиляTableAdapter;
        private System.Windows.Forms.TextBox номер_кузоваTextBox;
        private System.Windows.Forms.TextBox номер_двигателяTextBox;
        private System.Windows.Forms.TextBox пробегTextBox;
        private System.Windows.Forms.DateTimePicker дата_последнего_ТОDateTimePicker;
        private System.Windows.Forms.BindingSource марка_автомобиляBindingSource;
        private System.Windows.Forms.ComboBox код_маркиComboBox1;
        private System.Windows.Forms.ComboBox код_сотрудника_механикаComboBox;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private TaxiDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.MaskedTextBox год_выпускаMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox регистрационный_номерTextBox;
    }
}