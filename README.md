# Album Organizer

##### Catalog and organize albums

#### By **Matt Carlson**

## Description

The idea here was to practice using object oriented C# and the Nancy web application framework by creating a web app where a user can input albums and search them by artist.
There is a class for Albums and a class for Artists, and each instance of the Album class contains an Artist object.
The root page lists out all of the user's albums; if they haven't made any, it displays a welcome message. There is also a link to add a new album.
This goes to a page that contains a form to create a new album by adding an album title and an artist. When the form is submitted, the app 
instantiates new album and artist objects, creates a list of all the albums, and returns the home page displaying that list.

There is also a search page that returns a form for the user to input an artist name. When this is submitted, the app assigns the content of the form to a variable, 
returns a list of all the album objects, and runs a method that returns all the albums with an artist name containing that variable. It then displays
this list in the DOM.

This search feature was the most challenging thing to implement because it returns albums where any part of the artist name matches the term being searched for.
Meaning that if the user has created a CD object by "JS Bach" they should be able to search for it by typing in "bach", "Bach", and "Johann Sebastian Bach".
And that if the user has a CD by "Bachman–Turner Overdrive" as well as one by "JS Bach", if the user searches by the name "bach", or "Bach", both the CDs by "JS Bach" and "Bachman–Turner Overdrive" are displayed.

## Technologies Used

* C#
* Nancy
* HTML
* CSS
