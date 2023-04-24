# SSF
Standardized Save Files - all your saves in one place for easy backup or transfer.

Puts saves all into one folder as standard files, so they can be used in external applications (Git, Nextcloud) easily

# Roadmap
- [ ] Basic functionality
  - [ ] Create project
  - [ ] Windows and Linux support
  - [ ] C# API for developers
    - C++/Rust in the future?
  - [ ] Symlink support for existing applications
  - [ ] User configuration
    - [ ] Changable location of save files (My Games, AppData, Home folder) in ([YAML](https://github.com/aaubry/YamlDotNet/commits/master)) file 'ssf.yaml' in `.ssf/config` folder
    - [ ] Save in `~/.ssf/saves` by default
      - [ ] One folder for each program
    - [ ] Category that user can opt into/out of (games/emulators/office)
    - [ ] Regex include files
    - [ ] Regex exclude files
  - [ ] Ready to go defaults for applications (Unity and Unreal Engine application saves, Adobe Creative Cloud, etc)
    - [ ] Categories of saves in different files
  - [ ] Check for updates
- [ ] Backups
  - [ ] Compress all saves into `.ssf/backups` folder
  - [ ] Complete backup
    - [ ] Restore and overwrite all saves from backup zip
    - [ ] Automatic backups on user-defined time
  - [ ] Individual saves
    - [ ] Backup saves
    - [ ] Restore and overwrite saves from backup
    - [ ] Backup on each save
- [ ] GUI
  - [ ] Enable/disable categories
  - [ ] Enable/disable specific saves
  - [ ] Add/delete/disable new saves
  
