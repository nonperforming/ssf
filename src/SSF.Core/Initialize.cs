//
//  Initialize.cs - Standardized Save Files
//   Copyright (C) 2023  'nonperforming'
//
//    This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License as
//  published by the Free Software Foundation, either version 3 of the
//  License, or (at your option) any later version.
//
//  You should have received a copy of the GNU Affero General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;  

namespace SSF.Core
{
  internal class Initialize
  {
    internal bool Setup(string? configPath = null, bool failed = false)
    {
      configPath ??= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".ssf");

      try
      {
        SetupLogger(Path.Combine(configPath, "/logs"));
      }
      catch (DirectoryNotFoundException)
      {
        if (failed) return false;

        Log.Error($"Creating directory ");

        Directory.CreateDirectory(configPath);
        return Setup(failed: true);
      }
      catch (Exception ex)
      {
        if (failed) return false;

        Log.Error($"Exception {ex} met while initializing, returning to defaults");
        return Setup(failed: true);
      }

      return true;
    }

    internal void SetupLogger(string logLocation)
    {
      try
      {
        using var log = new LoggerConfiguration()
          .WriteTo.File(logLocation, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 30)
          .WriteTo.Console()
          .CreateLogger();

        Log.Logger = log;
      }
      catch (Exception ex)
      {
        return;
      }
      Log.Information("Serilog started");
    }
  }
}
