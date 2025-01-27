# Equipo5_ConstruccionSoftware

Video describing the game: https://drive.google.com/file/d/16rGMSU2RxlF3mPcDeFqp5GPhbFm0uyQj/view

---

# Installation and execution instructions

### **Using GitHub**
For those who don't have enough experience using GitHub directly on the terminal, we highly recommend using GitHub Desktop to clone or fork the repository.

Link with the installation process: https://desktop.github.com

Cloning and forking repositories from GitHub Desktop: https://docs.github.com/es/desktop/contributing-and-collaborating-using-github-desktop/adding-and-cloning-repositories/cloning-and-forking-repositories-from-github-desktop

### **Installing Node Js and MySQL Workbench**

Once the repo has been cloned or forked correctly, it is time to install MYSQL Workbench and Node js.

Node js Installation process: https://docs.npmjs.com/downloading-and-installing-node-js-and-npm. 

**IMPORTANT** - It is necessary to mention that this project contains a package.json with the node modules used for this project. You must install these modules before testing the API.

Link to install node module form package.json file: https://docs.npmjs.com/downloading-and-installing-node-js-and-npm

MySQL Workbench installation guide: https://www.youtube.com/watch?v=u96rVINbAUI

---

# Creating a User Admin from MySQL Workbench

In order to utilize the various API call to select, update or delete information from the database it is important to configure the user_admin privileges for that specific database. 

### **Running the script**

1) Open MySQL Workbench and select the local instance created in the installation process
![image info](./README_SCREENSHOTS/mysql_screen.jpg)

2) Click the File Option and select 
![image info](./README_SCREENSHOTS/open_schema.jpg)

3) Select the Folder of the repo and select the MySQL folder. Once inside select game_api_final and click on open.
![image info](./README_SCREENSHOTS/open_script.jpg)

4) Once opened it is important to excecute the script in order to create the database with the various tables, views and stored procedures.
![image info](./README_SCREENSHOTS/run_scheme.jpg)

5) Once executed you can then select the line of use percussio_island3 to select the database.
![image info](./README_SCREENSHOTS/administator.jpg)

### **Creating the user**

Now that we have successfully created our database locally we must create a user that will have the privilege of selecting, updating, and viewing required in our API calls.

1) Inside MySQL Workbench click on the Administration Tab and select User and privilieges.
![image info](./README_SCREENSHOTS/users.jpg)

2) Click on the tab **Add Acount** in order to register a new user.
![image info](./README_SCREENSHOTS/add_acount.jpg)

3) Type the name of the user as well as its password. Write this information somewhere place so we can access it easily during the API configuration. Once finished click on the Apply tab.
![image info](./README_SCREENSHOTS/apply_user.jpg)

4) Once the user has been created we need to establish its privileges on the database. For this click on the tab Scheme Prvileges, and click on Add Entry.
![image info](./README_SCREENSHOTS/add_privileges.jpg)

5) Once clicked you a new window to select the specific schema you want to grant privilages. Once selected our database click Ok.
![image info](./README_SCREENSHOTS/select_schema.jpg)

6) The next step consists on selecting which actions does the user have inside the data base. Be sure to mark SELECT, INSERT, UPDATE, DELETE AND EXECUTE and click the tab Apply.
![image info](./README_SCREENSHOTS/select_rights.jpg)

### **API user configuration**

Now that the user has been created successfully it is time to set our API in with the user information. In the root of the project /api select users_api.js. In line 31 there is a function that allows the connection of the API and database. Be sure to have the host value in ***localhost**, user and data with the database user created in MySQL Workbench and select the name of the Schema in database.
![image info](./README_SCREENSHOTS/api_user.jpg)

**IMPORTANT** - Be sure that your api is listening on port 5000. If you decide to change the port you must change not only the API calls but also inside the Unity project.
![image info](./README_SCREENSHOTS/api_conection.jpg)

---
# Creating a User Admin from MySQL Workbench

Once the database and the user administrator have been configured on the API, it is time to excecute it from the terminal. Be sure to call the node from the Back Folder.

![image info](./README_SCREENSHOTS/run_api.jpg)

If everything is running correctly you can view the webpage from the web browser.
![image info](./README_SCREENSHOTS/open_web.jpg)

---

Repositorio para el proyecto del equipo 5 de Construcción de Software y Toma de Desiciones
- Andrés Briseño Celada - A01352283
- Salvador Salgado Normandia - A01422874
- Iván Rodríguez Cuevas - A01781284
- Iwalani Amador Piaga - A01732251

---

# Useful references

- MIDI rhythm game tutorial: https://www.youtube.com/watch?v=ev0HsmgLScg
- MIDI Rhythm game repo: https://github.com/SkyanSam/RhythmGameTutorialProject
- Two buttons rhythm game: https://www.youtube.com/watch?v=89KpbT_7Ysg
- Top down Pokémon-like RPG tutorials: https://www.youtube.com/playlist?list=PLLf84Zj7U26kfPQ00JVI2nIoozuPkykDX
- Top down tileset: https://jamiebrownhill.itch.io/solaria-rural-village
- MIDI editor (LMMS): https://lmms.io/download#windows
- Percussion Library: https://philharmonia.co.uk/resources/sound-samples/
- Unity Esentianls Tutorials: https://learn.unity.com/pathways
- Unity Installer Guide: https://learn.unity.com/tutorial/install-the-unity-hub-and-editor#
- Memory Sund game tutorial: https://youtube.com/playlist?list=PL5dhcDELiazZ5Qdhcq2FrrnWSVxkkO7Yk

# Asset credits
- Menu SFX: https://souptonic.itch.io/souptonic-sfx-pack-1-ui-sounds
- Character sprite sheets:https://jamiebrownhill.itch.io/solaria-sprites
- World tileset sprite sheets: https://jamiebrownhill.itch.io/solaria-rural-village
- Interior tileset sprite sheets: https://jamiebrownhill.itch.io/solaria-quiet-cabin
- Snare drum art: https://opengameart.org/content/snare-drum

# Script sources
- RPG part of the game is heavily based on this tutorial series by Game Dev Experiments: https://www.youtube.com/playlist?list=PLLf84Zj7U26kfPQ00JVI2nIoozuPkykDX

# Information sources
- Trivia game information sources: https://vicfirth.zildjian.com/education/percussion-101.html
