#My way of "How to use it"
Clone this code and build it. Copy the generated nuget files in a folder(from both 2 projects). Then add this folder in nuget feeds like this -> [hosting-your-own-nuget-feeds](https://docs.nuget.org/create/hosting-your-own-nuget-feeds)
Then you can add this packages like any others.

# Open XML SDK for NET Platform Standard 1.6 & .NET Core 1.0
a NET Platform Standard 1.6 implementation of Open XML SDK 2.5 

This library(https://github.com/OfficeDev/Open-XML-SDK) was the only library that was holding back our project from supporting .net core. We didn't get any feedback from the team that created(there are more than 5 issues about it) and we couldn't wait. 
So I copied the code and i tried it out.
Guess what, it went well. What we use seems to be fine.

I had to copy some classes from core-fx repo to make it work in Utility.Xml project. Also some errors are quickly dirty fixed. The problem was with the XmlTextWriter (its internal in core-fx and this project inherit from this class).
