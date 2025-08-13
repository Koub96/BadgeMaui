# Badge MAUI

`BadgeMaui` provides the ability to attach a badge to any control in your .NET MAUI application.

`v1.0.0`

## Install Plugin

Available on [NuGet](https://www.nuget.org/packages/BadgeMaui/).

Install with the dotnet CLI: `dotnet add package BadgeMaui`, or through the NuGet Package Manager in Visual Studio.

### Supported Platforms

| Platform | Minimum Version Supported |
|----------|---------------------------|
| iOS      | 11+                       |
| macOS    | 10.15+                    |
| Android  | 5.0 (API 21)              |
| Windows  | 11 and 10 version 1809+   |

## API Usage

`BadgeMaui` is a UI control that is made up of two parts.
First, you must define the the `Badge.MainContent` in order to set the control on which the badge will be attached to.
Secondly, you can customize the badge via a range of properties described below or you can attach the badge with its default values.
In order to setup your badge content, set the `Badge.BadgeText` property.
You can also change the alginment of the badge via the `Badge.Align` property.

###Example XAML
<local:Badge HeightRequest="80" 
             WidthRequest="160" 
             BadgeText="1234" 
             BadgeCornerRadius="4" 
             BadgeHeight="29" 
             BadgeWidth="29"
             BadgeFontColor="White"
             BadgeFontSize="10"
             BadgeLineBreakMode="CharacterWrap"
             BadgeStrokeColor="Transparent"
             BadgeStrokeSize="0">
    <local:Badge.MainContent>
        <Button Text="Action"/>
    </local:Badge.MainContent>
</local:Badge>


### Permissions

No need for permissions.

#### iOS

No permissions are needed for iOS.

#### Android

No permissions are needed for Android.
