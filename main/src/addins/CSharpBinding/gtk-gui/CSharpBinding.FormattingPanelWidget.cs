// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CSharpBinding {
    
    
    internal partial class FormattingPanelWidget {
        
        private Gtk.VBox container;
        
        private Gtk.Label Indentation;
        
        private Gtk.HBox hboxIndentation;
        
        private Gtk.Label indentationSpacer;
        
        private Gtk.VBox vboxIndentation;
        
        private Gtk.CheckButton indentCaseLabels;
        
        private Gtk.Label LabelIndentation;
        
        private Gtk.HBox hboxLabelIndentation;
        
        private Gtk.Label labelIndentationSpacer;
        
        private Gtk.VBox vboxLabelIndentation;
        
        private Gtk.RadioButton indentGotoLabelsLeftJustify;
        
        private Gtk.RadioButton indentGotoLabelsUpOneLevel;
        
        private Gtk.RadioButton indentGotoLabelsNormally;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget CSharpBinding.FormattingPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "CSharpBinding.FormattingPanelWidget";
            // Container child CSharpBinding.FormattingPanelWidget.Gtk.Container+ContainerChild
            this.container = new Gtk.VBox();
            this.container.Name = "container";
            this.container.Spacing = 12;
            // Container child container.Gtk.Box+BoxChild
            this.Indentation = new Gtk.Label();
            this.Indentation.Name = "Indentation";
            this.Indentation.Xalign = 0F;
            this.Indentation.LabelProp = Mono.Unix.Catalog.GetString("<b>Indentation</b>");
            this.Indentation.UseMarkup = true;
            this.container.Add(this.Indentation);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.container[this.Indentation]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child container.Gtk.Box+BoxChild
            this.hboxIndentation = new Gtk.HBox();
            this.hboxIndentation.Name = "hboxIndentation";
            // Container child hboxIndentation.Gtk.Box+BoxChild
            this.indentationSpacer = new Gtk.Label();
            this.indentationSpacer.WidthRequest = 18;
            this.indentationSpacer.Name = "indentationSpacer";
            this.hboxIndentation.Add(this.indentationSpacer);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hboxIndentation[this.indentationSpacer]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hboxIndentation.Gtk.Box+BoxChild
            this.vboxIndentation = new Gtk.VBox();
            this.vboxIndentation.Name = "vboxIndentation";
            this.vboxIndentation.Spacing = 6;
            // Container child vboxIndentation.Gtk.Box+BoxChild
            this.indentCaseLabels = new Gtk.CheckButton();
            this.indentCaseLabels.CanFocus = true;
            this.indentCaseLabels.Name = "indentCaseLabels";
            this.indentCaseLabels.Label = Mono.Unix.Catalog.GetString("Indent case labels");
            this.indentCaseLabels.DrawIndicator = true;
            this.indentCaseLabels.UseUnderline = true;
            this.vboxIndentation.Add(this.indentCaseLabels);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vboxIndentation[this.indentCaseLabels]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            this.hboxIndentation.Add(this.vboxIndentation);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hboxIndentation[this.vboxIndentation]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.container.Add(this.hboxIndentation);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.container[this.hboxIndentation]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child container.Gtk.Box+BoxChild
            this.LabelIndentation = new Gtk.Label();
            this.LabelIndentation.Name = "LabelIndentation";
            this.LabelIndentation.Xalign = 0F;
            this.LabelIndentation.LabelProp = Mono.Unix.Catalog.GetString("<b>Label Indentation</b>");
            this.LabelIndentation.UseMarkup = true;
            this.container.Add(this.LabelIndentation);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.container[this.LabelIndentation]));
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            // Container child container.Gtk.Box+BoxChild
            this.hboxLabelIndentation = new Gtk.HBox();
            this.hboxLabelIndentation.Name = "hboxLabelIndentation";
            // Container child hboxLabelIndentation.Gtk.Box+BoxChild
            this.labelIndentationSpacer = new Gtk.Label();
            this.labelIndentationSpacer.WidthRequest = 18;
            this.labelIndentationSpacer.Name = "labelIndentationSpacer";
            this.hboxLabelIndentation.Add(this.labelIndentationSpacer);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hboxLabelIndentation[this.labelIndentationSpacer]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hboxLabelIndentation.Gtk.Box+BoxChild
            this.vboxLabelIndentation = new Gtk.VBox();
            this.vboxLabelIndentation.Name = "vboxLabelIndentation";
            this.vboxLabelIndentation.Spacing = 6;
            // Container child vboxLabelIndentation.Gtk.Box+BoxChild
            this.indentGotoLabelsLeftJustify = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Place goto labels in leftmost column"));
            this.indentGotoLabelsLeftJustify.CanFocus = true;
            this.indentGotoLabelsLeftJustify.Name = "indentGotoLabelsLeftJustify";
            this.indentGotoLabelsLeftJustify.Active = true;
            this.indentGotoLabelsLeftJustify.DrawIndicator = true;
            this.indentGotoLabelsLeftJustify.UseUnderline = true;
            this.indentGotoLabelsLeftJustify.Group = new GLib.SList(System.IntPtr.Zero);
            this.vboxLabelIndentation.Add(this.indentGotoLabelsLeftJustify);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vboxLabelIndentation[this.indentGotoLabelsLeftJustify]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child vboxLabelIndentation.Gtk.Box+BoxChild
            this.indentGotoLabelsUpOneLevel = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Place goto labels one indent less than current"));
            this.indentGotoLabelsUpOneLevel.CanFocus = true;
            this.indentGotoLabelsUpOneLevel.Name = "indentGotoLabelsUpOneLevel";
            this.indentGotoLabelsUpOneLevel.DrawIndicator = true;
            this.indentGotoLabelsUpOneLevel.UseUnderline = true;
            this.indentGotoLabelsUpOneLevel.Group = this.indentGotoLabelsLeftJustify.Group;
            this.vboxLabelIndentation.Add(this.indentGotoLabelsUpOneLevel);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vboxLabelIndentation[this.indentGotoLabelsUpOneLevel]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vboxLabelIndentation.Gtk.Box+BoxChild
            this.indentGotoLabelsNormally = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Indent goto labels normally"));
            this.indentGotoLabelsNormally.CanFocus = true;
            this.indentGotoLabelsNormally.Name = "indentGotoLabelsNormally";
            this.indentGotoLabelsNormally.DrawIndicator = true;
            this.indentGotoLabelsNormally.UseUnderline = true;
            this.indentGotoLabelsNormally.Group = this.indentGotoLabelsLeftJustify.Group;
            this.vboxLabelIndentation.Add(this.indentGotoLabelsNormally);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vboxLabelIndentation[this.indentGotoLabelsNormally]));
            w10.Position = 2;
            w10.Expand = false;
            w10.Fill = false;
            this.hboxLabelIndentation.Add(this.vboxLabelIndentation);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hboxLabelIndentation[this.vboxLabelIndentation]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            this.container.Add(this.hboxLabelIndentation);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.container[this.hboxLabelIndentation]));
            w12.Position = 3;
            w12.Expand = false;
            w12.Fill = false;
            this.Add(this.container);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
