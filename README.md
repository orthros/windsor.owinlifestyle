# windsor.owinlifestyle
Extension Library for Allowing PerWebRequest Lifestyles in a self-hosted Owin app

## The Obvious question: Why?
As we know, Castle.Windsor has the PerWebRequest Lifestyle. The issue with this, however, is Castle.Windsor requires a  IHttpModule to be registered in the web.config like so
```xml
<httpModules>
   <add name="PerRequestLifestyle" type="Castle.MicroKernel.Lifestyle.PerWebRequestLifestyleModule, Castle.Windsor"/>
</httpModules>
```
This, of course necessitates the application be hosted in IIS.

The goal of this repository is to allow for Castle.Windsor to be used in an Asp.NET MVC or WebApi2 app to use.

## Contributing
Pull requests are welcome!
