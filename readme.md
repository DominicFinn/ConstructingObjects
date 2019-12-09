# Constructing Objects 

This repository is part of a talk for Tech Weekly on building objects you can trust.

The synopsis of the talk is: 

"So many errors come from simple mistakes like null reference exceptions, we can defend against these errors in many ways and in many places but at what cost to complexity!??! Let’s discuss how we push these problems to the edges of our domain and place the responsibility in safer more predictable places"

I want to remind people of both the need to code defensively and where that bureden of responsibility should lie. 

For example, you should not have to check if a String property is null or empty in every location it's used. 

The inspiration from this came from a Zoran Horvat video on Pluralsight I'd watched some time ago. A great phrase he'd coined was

> If you have the object, then it’s fine.

An object should always be in a stable state no matter it's state. 

I love the side effects of this being the case. It reduces complexity everywhere, makes testing much more simple and forces quality (as much as it can)
