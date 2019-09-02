/* A fun game 
 * for a break on this crazy
 * huge project
 */

const Screen = document.getElementById("Game");
const ctx = Screen.getContext('2d');

const head = (x, y) =>{
    ctx.rect(x, y, 10, 10);
    ctx.fill();
}

const load = () => { head(250, 490); ctx.stroke(); }


load();