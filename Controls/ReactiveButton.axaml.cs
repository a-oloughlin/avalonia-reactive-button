namespace AvaloniaUIComponents.Controls;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using ReactiveUI;

[PseudoClasses(":executing")]
public class ReactiveButton : Button
{

    /// <summary>
    /// Command StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<IReactiveCommand> ReactiveCommandProperty =
        AvaloniaProperty.Register<ReactiveButton, IReactiveCommand>(nameof(Command));

    /// <summary>
    /// Gets or sets the Command property. 
    /// </summary>
    public IReactiveCommand ReactiveCommand
    {
        get => this.GetValue(ReactiveCommandProperty);
        private set => SetValue(ReactiveCommandProperty, value);
    }

    /// <summary>
    /// IsExecuting StyledProperty definition
    /// </summary>
    public static readonly StyledProperty<bool> IsExecutingProperty =
        AvaloniaProperty.Register<ReactiveButton, bool>(nameof(IsExecuting), default);

    /// <summary>
    /// Gets or sets the IsExecuting property. 
    /// </summary>
    public bool IsExecuting
    {
        get => this.GetValue(IsExecutingProperty);
        private set => SetValue(IsExecutingProperty, value);
    }

    static ReactiveButton()
    {
        IsExecutingProperty.Changed.AddClassHandler<ReactiveButton>((x, e) =>
        {
            if (e.NewValue is bool isExecuting)
            {
                x.PseudoClasses.Set(":executing", isExecuting);
            }
        });

        CommandProperty.Changed.AddClassHandler<ReactiveButton>((x, e) =>
        {
            if (e.NewValue is IReactiveCommand command)
            {
                x.ReactiveCommand = command;
            }
            else
            {
                x.ReactiveCommand = null;
                x.IsExecuting = false;
            }
        });
    }
}