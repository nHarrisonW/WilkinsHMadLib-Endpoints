# WilkinsHMadLib-Endpoints

THIS PROJECT ALLOWS THE USER TO INPUT MAD LIB ANSWER VIA THE URL. THEN OUTPUT A SENTENCE ACCORDING TO THE USERS'S ANSWERS

Peer review by Carlos Felipe - This code worked after HttpHead was changed to HttpGet after that it worked flawlessly. 

This program can be ran easily , setting up web API's is fun! First, after obtaining the repository link for this program you will find "MadLibController" in the explorer on the left. This is the only controller that is relevant for the project. It contains comments in the top regarding the project, although these comments are useless to the user

In order to use "MadLibController" correctly , first you must debug your system , debugging your system is possible by press the "fn" key at the same time as the "f5" key , although this does not always work the first time

If you see a small green arrow pointing left on the left side towards the top of the screen , you are almost there. Press the green arrown and a small bar should pop up at the top of the screen , three things this bar should contain is a set of two blue upright lines , representing a pause button , a green circular arrow representing a refresh / rerun button , and a red square representing a stop button , among other buttons that are irrelevant for now , these pause , refresh , and stop buttons refer to the API being ran through the internet

If you do not see this bar , you may have something wrong with your system , try reloading the repository link in a new file , or restart your system

Another way to debug your system is by going to the top of the screen , find "Run" , then select the option "Start debugging" , the same sequences listed in the paragraphs above should happen

Once your API is ran properly , you should be taken to your web browser with a prompt that the website is not secure , or something along those lines , this is expected , click the link in the search bar at the top of the browser , you should be presented with a URL that looks something like this : https://localhost:1234

Once this link is presented , copy onto your clipboard using Ctrl(command on Mac) + C , then paste it into your Postman desktop app using Ctrl(command on Mac) + V , the bar to enter this URL should be at the top of your Postman desktop app when you are in your workspace , make sure the blue box on the left of the search bar has the word "GET" in it , if it does not you should click the box and select "GET"

After you paste the URL you must follow it with a route or the controller will not work , these routes include "/MadLib" & "/game" as well as 10 words of your choice , all to be preceded by a "/" , the same as all other routes , below i will show you how to use these routes, follow close , they are case sensitive! I will be using the URL "https://localhost:1234" as my "mock" URL

In order to reach a response from the program , type "/MadLib/game/wordOne/wordTwo/wordThree/wordFour/wordFive/wordSix/wordSeven/wordNotFixed/wordVariable" directly behind your URL and press "ENTER" on your keyboard or "SEND" on your Postman Desktop App 
it should look something like this : https://localhost:1234/MadLib/game/wordOne/wordTwo/wordThree/wordFour/wordFive/wordSix/wordSeven/wordNotFixed/wordVariable
This would output a story including "wordOne" "wordTwo" "wordThree" "wordFour" "wordFive" "wordSix" "wordSeven" "wordEight" "wordNotFixed" "wordVariable" because these are all variables that you entered. The words can be anything!

If your URL doesn't look like one of these options , check to make sure your routes in the URL match , URL's ARE CASE SENSITIVE!

If you would like to play again , simply replace the last 10 "routes" at the end of the URL with different words and press "ENTER" on your keyboard or "SEND" on your Postman Desktop App once again , it should continue to produce a prompted paragraph everytime until the API is stopped or the URL is changed

To stop the API , go back to your Virtual Studio Code and click the red square in the middle of the top of your window

THAT'S ALL THERE IS TO IT! THANKS FOR PLAYING MY GAME!
