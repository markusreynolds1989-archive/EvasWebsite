/* A fun game 
 * for a break on this crazy
 * huge project
 */

const Screen = document.getElementById("Game");
const ctx = Screen.getContext('2d');
let score = "Score: " + 0;

/* here's the head and it's current position */
const head = (x, y) =>
{
    ctx.rect(x, y, 10, 10);
    ctx.fill();
}

/* draw the score on the top right */
let putScore = (score) =>
{
    ctx.font = '24px serif';
    ctx.fillText(score, 370, 30);
};

/* what happens on screen on load */
const load = () =>
{
    head(250, 490);
    putScore(score);
    ctx.stroke();
}

/*char => int => int*/
/*takes a key press and returns an integer or logic to add */
const eventHandler = (e) => { return null;}

/*should be the update */
/*nothing => side effects*/
const gameUpdate = () => { return "TEST";}

load();

gameUpdate();