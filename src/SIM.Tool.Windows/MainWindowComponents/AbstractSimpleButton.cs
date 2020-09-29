﻿namespace SIM.Tool.Windows.MainWindowComponents
{
  using System.Windows;
  using SIM.Instances;
  using SIM.Tool.Base.Plugins;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  public abstract class WindowOnlyButton : IMainWindowButton
  {
    #region Public methods

    public virtual bool IsEnabled(Window mainWindow, Instance instance)
    {
      return true;
    }

    public virtual bool IsVisible(Window mainWindow, Instance instance)
    {
      return true;
    }

    public virtual void OnClick(Window mainWindow, Instance instance)
    {
      Assert.ArgumentNotNull(mainWindow, nameof(mainWindow));

      OnClick(mainWindow);
    }

    #endregion

    #region Protected methods

    protected abstract void OnClick([NotNull] Window mainWindow);

    #endregion
  }
}