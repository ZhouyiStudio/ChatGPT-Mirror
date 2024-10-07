namespace ChatGPT_Mirror
{
    partial class ChatGPT
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatGPT));
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            this.SendButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.MessagetoChatGPT = new System.Windows.Forms.TextBox();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResponseMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Depth = 0;
            this.SendButton.Icon = ((System.Drawing.Image)(resources.GetObject("SendButton.Icon")));
            this.SendButton.Location = new System.Drawing.Point(288, 574);
            this.SendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(56, 56);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "SendButton";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessagetoChatGPT
            // 
            this.MessagetoChatGPT.Font = new System.Drawing.Font("萍方0", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessagetoChatGPT.Location = new System.Drawing.Point(12, 574);
            this.MessagetoChatGPT.Multiline = true;
            this.MessagetoChatGPT.Name = "MessagetoChatGPT";
            this.MessagetoChatGPT.Size = new System.Drawing.Size(270, 56);
            this.MessagetoChatGPT.TabIndex = 1;
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem4.SecondaryText = "ChatGPT-Mirror 1.0";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "ChatGPT-Mirror 1.0";
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "GPT.Zhouyi.Blog";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "ChatGPT回复👇👇👇";
            this.materialListBox1.Items.Add(materialListBoxItem4);
            this.materialListBox1.Items.Add(materialListBoxItem5);
            this.materialListBox1.Items.Add(materialListBoxItem6);
            this.materialListBox1.Location = new System.Drawing.Point(12, 12);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(332, 120);
            this.materialListBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "回复：";
            // 
            // ResponseMessage
            // 
            this.ResponseMessage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResponseMessage.Location = new System.Drawing.Point(12, 183);
            this.ResponseMessage.Multiline = true;
            this.ResponseMessage.Name = "ResponseMessage";
            this.ResponseMessage.Size = new System.Drawing.Size(331, 378);
            this.ResponseMessage.TabIndex = 4;
            // 
            // ChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 642);
            this.Controls.Add(this.ResponseMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialListBox1);
            this.Controls.Add(this.MessagetoChatGPT);
            this.Controls.Add(this.SendButton);
            this.Name = "ChatGPT";
            this.Text = "ChatGPT-Mirror";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFloatingActionButton SendButton;
        private System.Windows.Forms.TextBox MessagetoChatGPT;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResponseMessage;
    }
}

