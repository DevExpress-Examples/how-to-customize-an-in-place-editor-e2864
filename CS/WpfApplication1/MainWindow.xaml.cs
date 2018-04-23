using System.Windows;
using DevExpress.Xpf.Scheduler;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        #region #InplaceEditorShowing
        private void schedulerControl1_InplaceEditorShowing(object sender, InplaceEditorEventArgs e) {
            CustomInplaceEditor editor = new CustomInplaceEditor(schedulerControl1, e.Appointment);
            e.InplaceEditor = editor;
            editor.DataContext = editor;
            e.Bounds = new Rect(e.Bounds.TopRight, new Size(editor.Width, editor.Height));
        }
        #endregion #InplaceEditorShowing
    }
}