using Microsoft.Maui.Controls.Shapes;

namespace BadgeMaui.Control;

public partial class Badge : ContentView
{
    #region Bindable Properties
    public static readonly BindableProperty MainContentProperty = BindableProperty.Create(
        "MainContent",
        typeof(View),
        typeof(Badge),
        default(View),
        propertyChanged: OnMainContentChanged
    );
    static void OnMainContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not View) return;

        Badge badge = (Badge)bindable;
        
        if (newValue is null)
        { 
            badge.ViewContent.Content = default(View);
            return;
        }

        badge.ViewContent.Content = newValue as View;
    }
    public static readonly BindableProperty AlignProperty = BindableProperty.Create(
        "Align",
        typeof(AlignOptions),
        typeof(Badge),
        AlignOptions.Right,
        propertyChanged: OnAlignmentChanged
    );
    static void OnAlignmentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not AlignOptions) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        if (badge.BadgeView is null)
            return;

        badge.SetBadgeX();
    }

    public static readonly BindableProperty BadgeHeightProperty = BindableProperty.Create(
        "BadgeHeight",
        typeof(double),
        typeof(Badge),
        24.0,
        propertyChanged: OnBadgeHeightChanged
    );
    static void OnBadgeHeightChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not double) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeView.HeightRequest = (double)newValue;

        if (badge.ViewContent.Content is null) return;

        badge.SetBadgeX();
        badge.SetBadgeY();
    }
    public static readonly BindableProperty BadgeWidthProperty = BindableProperty.Create(
        "BadgeWidth",
        typeof(double),
        typeof(Badge),
        24.0,
        propertyChanged: OnBadgeWidthChanged
    );
    static void OnBadgeWidthChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not double) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeView.WidthRequest = (double)newValue;

        if (badge.ViewContent.Content is null) return;

        badge.SetBadgeX();
        badge.SetBadgeY();
    }
    public static readonly BindableProperty BadgeTextProperty = BindableProperty.Create(
        "BadgeText",
        typeof(string),
        typeof(Badge),
        "",
        propertyChanged: OnBadgeTextChanged
    );
    static void OnBadgeTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not string) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        if (badge.BadgeView is null)
            return;

        badge.BadgeLabel.Text = newValue as string;
    }
    public static readonly BindableProperty BadgeFontSizeProperty = BindableProperty.Create(
        "BadgeFontSize",
        typeof(double),
        typeof(Badge),
        10.0,
        propertyChanged: OnBadgeFontSizeChanged
    );
    static void OnBadgeFontSizeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not double) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        if (badge.BadgeView is null)
            return;

        badge.BadgeLabel.FontSize = (double)newValue;
    }
    public static readonly BindableProperty BadgeFontColorProperty = BindableProperty.Create(
        "BadgeFontColor",
        typeof(Color),
        typeof(Badge),
        Colors.White,
        propertyChanged: OnBadgeFontColorChanged
    );
    static void OnBadgeFontColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not Color) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        if (badge.BadgeView is null)
            return;

        badge.BadgeLabel.TextColor = (Color)newValue;
    }
    public static readonly BindableProperty BadgeBackgroundColorProperty = BindableProperty.Create(
        "BadgeBackgroundColor",
        typeof(Color),
        typeof(Badge),
        Colors.Red,
        propertyChanged: OnBadgeBackgroundColorChanged
    );
    static void OnBadgeBackgroundColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not Color) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BackgroundColor = (Color)newValue;
    }
    public static readonly BindableProperty BadgeLineBreakProperty = BindableProperty.Create(
        "BadgeLineBreakMode",
        typeof(LineBreakMode),
        typeof(Badge),
        LineBreakMode.NoWrap,
        propertyChanged: OnBadgeLineBreakModeChanged
    );
    static void OnBadgeLineBreakModeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not LineBreakMode) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeLabel.LineBreakMode = (LineBreakMode)newValue;
    }
    public static readonly BindableProperty BadgeCornerRadiusProperty = BindableProperty.Create(
        "BadgeCornerRadius",
        typeof(double),
        typeof(Badge),
        10.0,
        propertyChanged: OnBadgeCornerRadiusChanged
    );
    static void OnBadgeCornerRadiusChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not double) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeView.StrokeShape = new RoundRectangle { CornerRadius = new Microsoft.Maui.CornerRadius((double)newValue) };
    }
    public static readonly BindableProperty BadgeStrokeColorProperty = BindableProperty.Create(
        "BadgeStrokeColor",
        typeof(Color),
        typeof(Badge),
        Colors.Black,
        propertyChanged: OnBadgeStrokeColorChanged
    );
    static void OnBadgeStrokeColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not Color) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeView.Stroke = new SolidColorBrush((Color)newValue);
    }
    public static readonly BindableProperty BadgeStrokeSizeProperty = BindableProperty.Create(
        "BadgeStrokeSize",
        typeof(double),
        typeof(Badge),
        2.0,
        propertyChanged: OnBadgeStrokeSizeChanged
    );
    static void OnBadgeStrokeSizeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not double) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
            return;

        badge.BadgeView.StrokeThickness = (double)newValue;
    }
    #endregion

    #region Properties
    public View MainContent
    {
        get => (View)GetValue(MainContentProperty);
        set => SetValue(MainContentProperty, value);
    }
    public AlignOptions Align
    {
        get => (AlignOptions)GetValue(AlignProperty);
        set => SetValue(AlignProperty, value);
    }
    public double BadgeHeight
    {
        get => (double)GetValue(BadgeHeightProperty);
        set => SetValue(BadgeHeightProperty, value);
    }
    public double BadgeWidth
    {
        get => (double)GetValue(BadgeWidthProperty);
        set => SetValue(BadgeWidthProperty, value);
    }
    public string BadgeText
    {
        get => (string)GetValue(BadgeTextProperty);
        set => SetValue(BadgeTextProperty, value);
    }
    public double BadgeFontSize
    {
        get => (double)GetValue(BadgeFontSizeProperty);
        set => SetValue(BadgeFontSizeProperty, value);
    }
    public Color BadgeFontColor
    {
        get => (Color)GetValue(BadgeFontColorProperty);
        set => SetValue(BadgeFontColorProperty, value);
    }
    public Color BadgeBackgroundColor
    {
        get => (Color)GetValue(BadgeBackgroundColorProperty);
        set => SetValue(BadgeBackgroundColorProperty, value);
    }
    public LineBreakMode BadgeLineBreakMode
    {
        get => (LineBreakMode)GetValue(BadgeLineBreakProperty);
        set => SetValue(BadgeLineBreakProperty, value);
    }
    public double BadgeCornerRadius
    {
        get => (double)GetValue(BadgeCornerRadiusProperty);
        set => SetValue(BadgeCornerRadiusProperty, value);
    }
    public Color BadgeStrokeColor
    {
        get => (Color)GetValue(BadgeStrokeColorProperty);
        set => SetValue(BadgeStrokeColorProperty, value);
    }
    public double BadgeStrokeSize
    {
        get => (double)GetValue(BadgeStrokeSizeProperty);
        set => SetValue(BadgeStrokeSizeProperty, value);
    }
    #endregion

    #region Constructor
    public Badge()
	{
		InitializeComponent();

        this.ViewContent.SizeChanged += ViewContent_SizeChanged;
	}
    #endregion

    #region Events
    private void ViewContent_SizeChanged(object? sender, EventArgs e)
    {
        if (
            this.BadgeView is null ||
            this.ViewContent is null ||
            this.ViewContent.Content is null
        )
        {
            return;
        }

        SetBadgeX();
        SetBadgeY();
    }
    #endregion

    #region Private Methods
    private void SetBadgeX()
    {
        if (Align == AlignOptions.Left)
            this.BadgeView.TranslationX = -this.BadgeView.WidthRequest / 2;
        else
            this.BadgeView.TranslationX = this.ViewContent.Content.Width - this.BadgeView.WidthRequest / 2;
    }
    private void SetBadgeY()
    {
        this.BadgeView.TranslationY = -this.BadgeView.HeightRequest / 2;
    }
    #endregion

    //In case we want a generic badge placeholder
    /*public static readonly BindableProperty BadgeContentProperty = BindableProperty.Create(
        "BadgeContent",
        typeof(View),
        typeof(Badge),
        default(View),
        propertyChanged: OnBadgeContentChanged
    );
    static void OnBadgeContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is null) return;
        if (bindable is not Badge) return;
        if (newValue is not View) return;

        Badge badge = (Badge)bindable;

        if (newValue is null)
        {
            badge.BadgeView.Content = default(View);
            return;
        }

        badge.BadgeView.HeightRequest = ((View)newValue).HeightRequest;
        badge.BadgeView.WidthRequest = ((View)newValue).WidthRequest;
        badge.BadgeView.Content = newValue as View;
    }*/
    /*public View BadgeContent
    {
        get => (View)GetValue(BadgeContentProperty);
        set => SetValue(BadgeContentProperty, value);
    }*/
}