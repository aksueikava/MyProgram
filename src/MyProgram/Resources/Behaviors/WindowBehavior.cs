using Microsoft.Xaml.Behaviors;
using System.Windows;

namespace MyProgram.Resources.Behaviors
{
    public sealed class WindowBehavior : Behavior<Window>
    {
        public static readonly DependencyProperty DragMoveProperty =
            DependencyProperty.RegisterAttached(
                "DragMove",
                typeof(bool),
                typeof(WindowBehavior),
                new PropertyMetadata(false));

        public bool DragMove
        {
            get => (bool)GetValue(DragMoveProperty);
            set => SetValue(DragMoveProperty, value);
        }

        protected override void OnAttached()
        {
            if (DragMove)
                MakeDragMove();
        }

        private void MakeDragMove()
        {
            static void Handle(object sender, System.Windows.Input.MouseButtonEventArgs e)
            {
                ((Window)sender).DragMove();
            }

            AssociatedObject.MouseLeftButtonDown += Handle;
        }
    }
}
