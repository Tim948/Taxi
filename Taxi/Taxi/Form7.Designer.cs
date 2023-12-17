namespace Taxi
{
    partial class F7
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
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label код_работыLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label откудаLabel;
            System.Windows.Forms.Label кудаLabel;
            System.Windows.Forms.Label код_тарифаLabel;
            System.Windows.Forms.Label код_сотрудника_оператораLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F7));
            this.taxiDataSet = new Taxi.TaxiDataSet();
            this.вызовыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вызовыTableAdapter = new Taxi.TaxiDataSetTableAdapters.ВызовыTableAdapter();
            this.tableAdapterManager = new Taxi.TaxiDataSetTableAdapters.TableAdapterManager();
            this.работаTableAdapter = new Taxi.TaxiDataSetTableAdapters.РаботаTableAdapter();
            this.сотрудникиTableAdapter = new Taxi.TaxiDataSetTableAdapters.СотрудникиTableAdapter();
            this.тарифыTableAdapter = new Taxi.TaxiDataSetTableAdapters.ТарифыTableAdapter();
            this.вызовыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.вызовыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_работыComboBox = new System.Windows.Forms.ComboBox();
            this.работаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.код_тарифаComboBox = new System.Windows.Forms.ComboBox();
            this.тарифыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_сотрудника_оператораComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            времяLabel = new System.Windows.Forms.Label();
            код_работыLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            код_тарифаLabel = new System.Windows.Forms.Label();
            код_сотрудника_оператораLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingNavigator)).BeginInit();
            this.вызовыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Location = new System.Drawing.Point(56, 85);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(51, 16);
            времяLabel.TabIndex = 5;
            времяLabel.Text = "Время:";
            // 
            // код_работыLabel
            // 
            код_работыLabel.AutoSize = true;
            код_работыLabel.Location = new System.Drawing.Point(22, 54);
            код_работыLabel.Name = "код_работыLabel";
            код_работыLabel.Size = new System.Drawing.Size(85, 16);
            код_работыLabel.TabIndex = 7;
            код_работыLabel.Text = "Код работы:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(37, 112);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.Location = new System.Drawing.Point(49, 140);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(58, 16);
            откудаLabel.TabIndex = 9;
            откудаLabel.Text = "Откуда:";
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.Location = new System.Drawing.Point(65, 168);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(42, 16);
            кудаLabel.TabIndex = 11;
            кудаLabel.Text = "Куда:";
            // 
            // код_тарифаLabel
            // 
            код_тарифаLabel.AutoSize = true;
            код_тарифаLabel.Location = new System.Drawing.Point(53, 193);
            код_тарифаLabel.Name = "код_тарифаLabel";
            код_тарифаLabel.Size = new System.Drawing.Size(54, 16);
            код_тарифаLabel.TabIndex = 13;
            код_тарифаLabel.Text = "Тариф:";
            // 
            // код_сотрудника_оператораLabel
            // 
            код_сотрудника_оператораLabel.AutoSize = true;
            код_сотрудника_оператораLabel.Location = new System.Drawing.Point(32, 227);
            код_сотрудника_оператораLabel.Name = "код_сотрудника_оператораLabel";
            код_сотрудника_оператораLabel.Size = new System.Drawing.Size(75, 16);
            код_сотрудника_оператораLabel.TabIndex = 17;
            код_сотрудника_оператораLabel.Text = "Оператор:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вызовыBindingSource
            // 
            this.вызовыBindingSource.DataMember = "Вызовы";
            this.вызовыBindingSource.DataSource = this.taxiDataSet;
            // 
            // вызовыTableAdapter
            // 
            this.вызовыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Taxi.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.ВызовыTableAdapter = this.вызовыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марка_автомобиляTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = this.работаTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.ТарифыTableAdapter = this.тарифыTableAdapter;
            // 
            // работаTableAdapter
            // 
            this.работаTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // тарифыTableAdapter
            // 
            this.тарифыTableAdapter.ClearBeforeFill = true;
            // 
            // вызовыBindingNavigator
            // 
            this.вызовыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вызовыBindingNavigator.BindingSource = this.вызовыBindingSource;
            this.вызовыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вызовыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вызовыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.вызовыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.вызовыBindingNavigatorSaveItem});
            this.вызовыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вызовыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вызовыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вызовыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вызовыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вызовыBindingNavigator.Name = "вызовыBindingNavigator";
            this.вызовыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вызовыBindingNavigator.Size = new System.Drawing.Size(378, 27);
            this.вызовыBindingNavigator.TabIndex = 0;
            this.вызовыBindingNavigator.Text = "bindingNavigator1";
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
            // вызовыBindingNavigatorSaveItem
            // 
            this.вызовыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вызовыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вызовыBindingNavigatorSaveItem.Image")));
            this.вызовыBindingNavigatorSaveItem.Name = "вызовыBindingNavigatorSaveItem";
            this.вызовыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.вызовыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.вызовыBindingNavigatorSaveItem.Click += new System.EventHandler(this.вызовыBindingNavigatorSaveItem_Click);
            // 
            // времяDateTimePicker
            // 
            this.времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.вызовыBindingSource, "Время", true));
            this.времяDateTimePicker.Location = new System.Drawing.Point(113, 81);
            this.времяDateTimePicker.Name = "времяDateTimePicker";
            this.времяDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.времяDateTimePicker.TabIndex = 6;
            // 
            // код_работыComboBox
            // 
            this.код_работыComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Код работы", true));
            this.код_работыComboBox.DataSource = this.работаBindingSource;
            this.код_работыComboBox.DisplayMember = "Код работы";
            this.код_работыComboBox.FormattingEnabled = true;
            this.код_работыComboBox.Location = new System.Drawing.Point(113, 51);
            this.код_работыComboBox.Name = "код_работыComboBox";
            this.код_работыComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_работыComboBox.TabIndex = 8;
            // 
            // работаBindingSource
            // 
            this.работаBindingSource.DataMember = "Работа";
            this.работаBindingSource.DataSource = this.taxiDataSet;
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(113, 137);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(200, 22);
            this.откудаTextBox.TabIndex = 10;
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(113, 165);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(200, 22);
            this.кудаTextBox.TabIndex = 12;
            // 
            // код_тарифаComboBox
            // 
            this.код_тарифаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Код тарифа", true));
            this.код_тарифаComboBox.DataSource = this.тарифыBindingSource;
            this.код_тарифаComboBox.DisplayMember = "Код тарифа";
            this.код_тарифаComboBox.FormattingEnabled = true;
            this.код_тарифаComboBox.Location = new System.Drawing.Point(113, 193);
            this.код_тарифаComboBox.Name = "код_тарифаComboBox";
            this.код_тарифаComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_тарифаComboBox.TabIndex = 14;
            // 
            // тарифыBindingSource
            // 
            this.тарифыBindingSource.DataMember = "Тарифы";
            this.тарифыBindingSource.DataSource = this.taxiDataSet;
            // 
            // код_сотрудника_оператораComboBox
            // 
            this.код_сотрудника_оператораComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Код сотрудника-оператора", true));
            this.код_сотрудника_оператораComboBox.DataSource = this.сотрудникиBindingSource;
            this.код_сотрудника_оператораComboBox.DisplayMember = "Код сотрудника";
            this.код_сотрудника_оператораComboBox.FormattingEnabled = true;
            this.код_сотрудника_оператораComboBox.Location = new System.Drawing.Point(113, 227);
            this.код_сотрудника_оператораComboBox.Name = "код_сотрудника_оператораComboBox";
            this.код_сотрудника_оператораComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_сотрудника_оператораComboBox.TabIndex = 18;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.taxiDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызовыBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(113, 109);
            this.телефонMaskedTextBox.Mask = "00000000000";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.телефонMaskedTextBox.TabIndex = 21;
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(378, 461);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_сотрудника_оператораLabel);
            this.Controls.Add(this.код_сотрудника_оператораComboBox);
            this.Controls.Add(код_тарифаLabel);
            this.Controls.Add(this.код_тарифаComboBox);
            this.Controls.Add(кудаLabel);
            this.Controls.Add(this.кудаTextBox);
            this.Controls.Add(откудаLabel);
            this.Controls.Add(this.откудаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(код_работыLabel);
            this.Controls.Add(this.код_работыComboBox);
            this.Controls.Add(времяLabel);
            this.Controls.Add(this.времяDateTimePicker);
            this.Controls.Add(this.вызовыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F7";
            this.Text = "Добавим новый вызов";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingNavigator)).EndInit();
            this.вызовыBindingNavigator.ResumeLayout(false);
            this.вызовыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource вызовыBindingSource;
        private TaxiDataSetTableAdapters.ВызовыTableAdapter вызовыTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вызовыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton вызовыBindingNavigatorSaveItem;
        private TaxiDataSetTableAdapters.РаботаTableAdapter работаTableAdapter;
        private System.Windows.Forms.DateTimePicker времяDateTimePicker;
        private System.Windows.Forms.ComboBox код_работыComboBox;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.ComboBox код_тарифаComboBox;
        private System.Windows.Forms.ComboBox код_сотрудника_оператораComboBox;
        private System.Windows.Forms.BindingSource работаBindingSource;
        private TaxiDataSetTableAdapters.ТарифыTableAdapter тарифыTableAdapter;
        private System.Windows.Forms.BindingSource тарифыBindingSource;
        private TaxiDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
    }
}