using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon SelectString.
/// </summary>
public sealed unsafe class ClickSelectString : ClickBase<ClickSelectString, AddonSelectString>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickSelectString"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickSelectString(IntPtr addon = default)
        : base("SelectString", addon)
    {
    }

    public static implicit operator ClickSelectString(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickSelectString Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Select the item at the given index.
    /// </summary>
    /// <param name="index">Index to select.</param>
    public void SelectItem(ushort index)
        => this.ClickAddonList(&this.Addon->PopupMenu.PopupMenu, index);

#pragma warning disable SA1134,SA1516,SA1600
    [ClickName("select_string1")] public void SelectItem1() => this.SelectItem(0);
    [ClickName("select_string2")] public void SelectItem2() => this.SelectItem(1);
    [ClickName("select_string3")] public void SelectItem3() => this.SelectItem(2);
    [ClickName("select_string4")] public void SelectItem4() => this.SelectItem(3);
    [ClickName("select_string5")] public void SelectItem5() => this.SelectItem(4);
    [ClickName("select_string6")] public void SelectItem6() => this.SelectItem(5);
    [ClickName("select_string7")] public void SelectItem7() => this.SelectItem(6);
    [ClickName("select_string8")] public void SelectItem8() => this.SelectItem(7);
    [ClickName("select_string9")] public void SelectItem9() => this.SelectItem(8);
    [ClickName("select_string10")] public void SelectItem10() => this.SelectItem(9);
    [ClickName("select_string11")] public void SelectItem11() => this.SelectItem(10);
    [ClickName("select_string12")] public void SelectItem12() => this.SelectItem(11);
#pragma warning restore SA1134,SA1516,SA1600
}
