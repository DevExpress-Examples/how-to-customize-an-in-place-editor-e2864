<!-- default file list -->
*Files to look at*:

* [CustomInplaceEditor.xaml](./CS/WpfApplication1/CustomInplaceEditor.xaml) (VB: [CustomInplaceEditor.xaml](./VB/WpfApplication1/CustomInplaceEditor.xaml))
* [CustomInplaceEditor.xaml.cs](./CS/WpfApplication1/CustomInplaceEditor.xaml.cs) (VB: [CustomInplaceEditor.xaml.vb](./VB/WpfApplication1/CustomInplaceEditor.xaml.vb))
* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize an in-place editor


<p>The following example demonstrates how to replace a standard in-place editor with a custom one.</p>


<h3>Description</h3>

<p>To implement a custom in-place editor, you should do the following:<br />
1. Create your own custom in-place editor using the <strong>AppointmentInplaceEditorBase</strong> class;<br />
2. Handle the <strong>InplaceEditorShowing</strong> event to show the newly created custom in-place editor instead of the default editor.</p>

<br/>


