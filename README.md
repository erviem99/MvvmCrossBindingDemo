Assigning the EntryElement.Value (from CrossUI.iOS.Dialog.Elements) property directly will not trigger an update in the viewmodel.

Steps to reproduce

Create a new empty iPhone project in Visual Studio 2015 Community Edition
Add Nuget package MvvmCross.StarterPack 4.1.0 to main project and Core project
Add Nuget package MvvmCross.Dialog to main project
Change Setup class to inherit from MvxIosDialogSetup
Create a new FirstView class that inherits from MvxDialogViewController
Add a Root to the new view that has a EntryElement and a StringElement and bind the two to the viewmodel's Hello property
Add a NavigationItem button that assigns the EntryElement.Value property when Clicked
Expected behavior

When the button is clicked the text in both the EntryElement and the StringElement should change to the assigned value

Actual behavior

Only the text in the EntryElement is changed

Configuration

Version: 4.1.0

Platform: iOS 9.3
