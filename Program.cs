// --- playerの初期設定・ステータス ---
int playerHp = 10;
int playerPower = 5;

// --- enemyの初期設定・ステータス ---
int enemyHp = 5;
int enemyPower = 3;

// --- バトル開始の演出 ---
Console.WriteLine("Game Start");
Console.WriteLine($"敵が現れた！（敵HP：{enemyHp}）");
Console.WriteLine("----------------------------");

// --- 攻撃処理 ---
enemyHp -= playerPower;

Console.WriteLine("プレイヤーの攻撃");
Console.WriteLine($"敵に{playerPower}のダメージを与えた!");
Console.WriteLine($"敵の残りHP：{enemyHp}");

// --- 勝敗判定 ---
if(enemyHp <= 0 && playerHp > 0){
    Console.WriteLine("You win!");
}
else if(enemyHp > 0 && playerHp <= 0){
    Console.WriteLine("You lose");
}

// TODO: 次回は while (playerHp > 0 && enemyHp > 0) を導入し、
// 勝敗が決まるまで「プレイヤー攻撃 → 敵の反撃」をループさせる