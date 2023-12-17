namespace Taxi
{
    partial class F3
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label технические_характеристикиLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label спецификаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3));
            this.taxiDataSet = new Taxi.TaxiDataSet();
            this.марка_автомобиляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.марка_автомобиляTableAdapter = new Taxi.TaxiDataSetTableAdapters.Марка_автомобиляTableAdapter();
            this.tableAdapterManager = new Taxi.TaxiDataSetTableAdapters.TableAdapterManager();
            this.марка_автомобиляBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.марка_автомобиляBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.технические_характеристикиTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.спецификаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            наименованиеLabel = new System.Windows.Forms.Label();
            технические_характеристикиLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            спецификаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingNavigator)).BeginInit();
            this.марка_автомобиляBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(13, 46);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(109, 16);
            наименованиеLabel.TabIndex = 1;
            наименованиеLabel.Text = "Наименование:";
            // 
            // технические_характеристикиLabel
            // 
            технические_характеристикиLabel.AutoSize = true;
            технические_характеристикиLabel.Location = new System.Drawing.Point(12, 81);
            технические_характеристикиLabel.Name = "технические_характеристикиLabel";
            технические_характеристикиLabel.Size = new System.Drawing.Size(203, 16);
            технические_характеристикиLabel.TabIndex = 3;
            технические_характеристикиLabel.Text = "Технические характеристики:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(13, 114);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(80, 16);
            стоимостьLabel.TabIndex = 5;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // спецификаLabel
            // 
            спецификаLabel.AutoSize = true;
            спецификаLabel.Location = new System.Drawing.Point(13, 151);
            спецификаLabel.Name = "спецификаLabel";
            спецификаLabel.Size = new System.Drawing.Size(85, 16);
            спецификаLabel.TabIndex = 7;
            спецификаLabel.Text = "Специфика:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // марка_автомобиляBindingSource
            // 
            this.марка_автомобиляBindingSource.DataMember = "Марка автомобиля";
            this.марка_автомобиляBindingSource.DataSource = this.taxiDataSet;
            // 
            // марка_автомобиляTableAdapter
            // 
            this.марка_автомобиляTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Taxi.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.ВызовыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марка_автомобиляTableAdapter = this.марка_автомобиляTableAdapter;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = null;
            // 
            // марка_автомобиляBindingNavigator
            // 
            this.марка_автомобиляBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.марка_автомобиляBindingNavigator.BindingSource = this.марка_автомобиляBindingSource;
            this.марка_автомобиляBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.марка_автомобиляBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.марка_автомобиляBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.марка_автомобиляBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.марка_автомобиляBindingNavigatorSaveItem});
            this.марка_автомобиляBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.марка_автомобиляBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.марка_автомобиляBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.марка_автомобиляBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.марка_автомобиляBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.марка_автомобиляBindingNavigator.Name = "марка_автомобиляBindingNavigator";
            this.марка_автомобиляBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.марка_автомобиляBindingNavigator.Size = new System.Drawing.Size(397, 31);
            this.марка_автомобиляBindingNavigator.TabIndex = 0;
            this.марка_автомобиляBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // марка_автомобиляBindingNavigatorSaveItem
            // 
            this.марка_автомобиляBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.марка_автомобиляBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("марка_автомобиляBindingNavigatorSaveItem.Image")));
            this.марка_автомобиляBindingNavigatorSaveItem.Name = "марка_автомобиляBindingNavigatorSaveItem";
            this.марка_автомобиляBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.марка_автомобиляBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.марка_автомобиляBindingNavigatorSaveItem.Click += new System.EventHandler(this.марка_автомобиляBindingNavigatorSaveItem_Click);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.марка_автомобиляBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(221, 40);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(132, 22);
            this.наименованиеTextBox.TabIndex = 2;
            // 
            // технические_характеристикиTextBox
            // 
            this.технические_характеристикиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.марка_автомобиляBindingSource, "Технические характеристики", true));
            this.технические_характеристикиTextBox.Location = new System.Drawing.Point(221, 75);
            this.технические_характеристикиTextBox.Name = "технические_характеристикиTextBox";
            this.технические_характеристикиTextBox.Size = new System.Drawing.Size(129, 22);
            this.технические_характеристикиTextBox.TabIndex = 4;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.марка_автомобиляBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(221, 114);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(132, 22);
            this.стоимостьTextBox.TabIndex = 6;
            // 
            // спецификаTextBox
            // 
            this.спецификаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.марка_автомобиляBindingSource, "Специфика", true));
            this.спецификаTextBox.Location = new System.Drawing.Point(221, 151);
            this.спецификаTextBox.Name = "спецификаTextBox";
            this.спецификаTextBox.Size = new System.Drawing.Size(132, 22);
            this.спецификаTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(спецификаLabel);
            this.Controls.Add(this.спецификаTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(технические_характеристикиLabel);
            this.Controls.Add(this.технические_характеристикиTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.марка_автомобиляBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F3";
            this.Text = "Добавить новый автомобиль";
            this.Load += new System.EventHandler(this.F3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.марка_автомобиляBindingNavigator)).EndInit();
            this.марка_автомобиляBindingNavigator.ResumeLayout(false);
            this.марка_автомобиляBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource марка_автомобиляBindingSource;
        private TaxiDataSetTableAdapters.Марка_автомобиляTableAdapter марка_автомобиляTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator марка_автомобиляBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton марка_автомобиляBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox технические_характеристикиTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox спецификаTextBox;
        private System.Windows.Forms.Button button1;
    }
}