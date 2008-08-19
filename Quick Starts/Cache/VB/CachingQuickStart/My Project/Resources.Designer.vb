﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CachingQuickStart.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The item is expected to change and should be refreshed at a defined time..
        '''</summary>
        Friend ReadOnly Property AbsoluteTimeExpirationMessage() As String
            Get
                Return ResourceManager.GetString("AbsoluteTimeExpirationMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item added to cache
        '''        Key: {0}
        '''        Product Name: {1}
        '''        Product Price: {2}
        '''        Expiration: {3}
        '''        Priority: {4}.
        '''</summary>
        Friend ReadOnly Property AddItemToCacheMessage() As String
            Get
                Return ResourceManager.GetString("AddItemToCacheMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item read from cache
        '''        Key: {0}
        '''        Name: {1}
        '''        Price: {2}.
        '''</summary>
        Friend ReadOnly Property CacheSourceMessage() As String
            Get
                Return ResourceManager.GetString("CacheSourceMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Data in storage was updated.
        '''</summary>
        Friend ReadOnly Property DataSavedMessage() As String
            Get
                Return ResourceManager.GetString("DataSavedMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The item has a particular lifetime, and should be expired upon completion of that lifetime..
        '''</summary>
        Friend ReadOnly Property ExtendedFormatExpirationMessage() As String
            Get
                Return ResourceManager.GetString("ExtendedFormatExpirationMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The item&apos;s lifetime is tied to a particular file. When that file changes, the item will be considered to be expired..
        '''</summary>
        Friend ReadOnly Property FileDependencyExpirationMessage() As String
            Get
                Return ResourceManager.GetString("FileDependencyExpirationMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cache has been flushed by user.
        '''</summary>
        Friend ReadOnly Property FlushCacheMessage() As String
            Get
                Return ResourceManager.GetString("FlushCacheMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following fields are required: Key, Product Name, Product Price..
        '''</summary>
        Friend ReadOnly Property InvalidInputMessage() As String
            Get
                Return ResourceManager.GetString("InvalidInputMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following field is required: Key.
        '''</summary>
        Friend ReadOnly Property InvalidKeyMessage() As String
            Get
                Return ResourceManager.GetString("InvalidKeyMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please select an item.
        '''</summary>
        Friend ReadOnly Property InvalidSelectionMessage() As String
            Get
                Return ResourceManager.GetString("InvalidSelectionMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item is no longer available.
        '''</summary>
        Friend ReadOnly Property ItemNotAvailableMessage() As String
            Get
                Return ResourceManager.GetString("ItemNotAvailableMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item not found in cache
        '''        Key: {0}.
        '''</summary>
        Friend ReadOnly Property ItemNotFoundMessage() As String
            Get
                Return ResourceManager.GetString("ItemNotFoundMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item read from master and added to cache
        '''        Key: {0}
        '''        Name: {1}
        '''        Price: {2}.
        '''</summary>
        Friend ReadOnly Property MasterSourceMessage() As String
            Get
                Return ResourceManager.GetString("MasterSourceMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The master copy of the item is not expected to change and the item will never be expired..
        '''</summary>
        Friend ReadOnly Property NeverExpiredExpirationMessage() As String
            Get
                Return ResourceManager.GetString("NeverExpiredExpirationMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The cache has been loaded with entire set of data.
        '''</summary>
        Friend ReadOnly Property ProactiveLoadMessage() As String
            Get
                Return ResourceManager.GetString("ProactiveLoadMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Caching Quick Start.
        '''</summary>
        Friend ReadOnly Property QuickStartTitleMessage() As String
            Get
                Return ResourceManager.GetString("QuickStartTitleMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Item read from cache
        '''        Key: {0}
        '''        Name: {1}
        '''        Price: {2}.
        '''</summary>
        Friend ReadOnly Property ReadItemFromCacheMessage() As String
            Get
                Return ResourceManager.GetString("ReadItemFromCacheMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Items are retrieved from the cache by their key. Enter the key of the item you would like to retrieve from the cache..
        '''</summary>
        Friend ReadOnly Property ReadItemMessage() As String
            Get
                Return ResourceManager.GetString("ReadItemMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Read Item from Cache.
        '''</summary>
        Friend ReadOnly Property ReadItemTitleMessage() As String
            Get
                Return ResourceManager.GetString("ReadItemTitleMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove operation complete..
        '''</summary>
        Friend ReadOnly Property RemoveItemFromCacheMessage() As String
            Get
                Return ResourceManager.GetString("RemoveItemFromCacheMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Items are removed from the cache by their key. Enter the key of the item you would like to remove from the cache..
        '''</summary>
        Friend ReadOnly Property RemoveItemMessage() As String
            Get
                Return ResourceManager.GetString("RemoveItemMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove Item from Cache.
        '''</summary>
        Friend ReadOnly Property RemoveItemTitleMessage() As String
            Get
                Return ResourceManager.GetString("RemoveItemTitleMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Whenever the item is not accessed for a specified time, it should be considered stale, and expired..
        '''</summary>
        Friend ReadOnly Property SlidingTimeExpirationMessage() As String
            Get
                Return ResourceManager.GetString("SlidingTimeExpirationMessage", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
