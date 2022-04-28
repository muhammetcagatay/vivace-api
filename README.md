<div id="top"></div>





<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/muhammetcagatay/VivaceAPI">
    <img src="https://www.ukeysoft.com/images/apple-music-icon.jpg" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Vivage API</h3>

  <p align="center">
    API Project About Music And Singers
    <br />
    <!--
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Request Feature</a>
    -->
  </p>
</div>

<!-- ABOUT THE PROJECT -->

##  About The Project

![Product Name Screen Shot](https://kinsta.com/wp-content/uploads/2019/12/wordpress-rest-api-1024x512.jpg)

This project was developed with .Net 6 framework. While developing the project, I used the N-Layer Architecture approach as the architectural approach.

There are 3 layers in the developed project:
* **Core Layer**<br>
  ```sh
   In this layer, the models in the database were created. In addition interfaces 
   of repository and service classes have been added.
   
   In addition, in this layer, the interface of the UnitOfWork class, which will 
   perform all operations to be done with the Database through a single channel 
   and keep it in memory, has been developed.
   
   Data Transfer Objects were created in order to request and respond to the data appropriately.
   
   ```
   
* **Data Layer**<br>
  ```sh
   In this layer, DbContext class was created and migration operations were performed. 
   In addition, the models created in the core layer were configured with the help of fluent api.
   
   Repository classes and UnitOfWork classes have been developed.
   
   Developed the UnitOfWork class, which will perform all operations with the 
   database through a single channel and keep them in memory.
   ```
   
* **Service Layer**<br>
  ```sh
   Service interfaces developed in the Core layer were implemented.
   
   Improved mapping classes used to transform data.
   ```
   

<p align="right">(<a href="#top">Back To Top</a>)</p>



## Built With

I used the following technologies while creating this API project.

* [.Net Core 6](https://docs.microsoft.com/tr-tr/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
* [Entity Framework Core 6](https://docs.microsoft.com/tr-tr/ef/core/)
* [SQL Server](https://www.google.com/search?client=opera&q=sql+server&sourceid=opera&ie=UTF-8&oe=UTF-8)
* [Visual Studio 2022](https://visualstudio.microsoft.com/tr/vs/)

<p align="right">(<a href="#top">Back To Top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/muhammetcagatay/VivaceAPI/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/muhammetcagatay/VivaceAPI/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/muhammetcagatay/VivaceAPI/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/muhammetcagatay/VivaceAPI/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/muhammetcagatayy/
[product-screenshot]: images/screenshot.png


