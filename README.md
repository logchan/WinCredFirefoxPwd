WinCred Firefox Password
---

Enter Firefox master password saved in Windows Credential Manager.

Created by logchan, who is tired of typing, and tired of managing his smartcard reader.

## What's this?

This project is a sequel to the smartcard-based solution [Smarter Firefox Password](https://github.com/logchan/SmarterFirefoxPassword/). It trades some security for some convenience.

It is created because the smartcard reader on my desk accidentally interacts with my phone too often. Plus I need a solution on my laptop as well.

The program checks once a second if Firefox is prompting for the master password. If so, it reads the credential and fills it.

## How to use

### Initial configuration

Open `Credential Manager` and select `Windows Credentials`. Look for `Generic Credentials`, and click the `Add a generic credential` button to its right. Enter these information:

```
Internet or network address: firefox-master
User name: <anything>
Password: <your Firefox master password>
```

## Requirements

### Software

- Windows 10
- .Net framework 4.8
- Visual Studio 2019

## License

[DBAD license](https://dbad-license.org/)