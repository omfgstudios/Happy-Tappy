﻿using UnityEngine;

public class SimpleLevelLoader : BaseLevelLoader
{
    // If desired all of this can be moved to simple level data and loaded on a per level basis.
    private static float X_MIN = -5f;
    private static float X_MAX = 5f;
    private static float Y_MIN = -3f;
    private static float Y_MAX = 3f;
    private static float TARGET_MIN = 0.5f;
    private static float TARGET_MAX = 1.5f;

    public override void loadLevel(BaseLevelData data, GameController game)
    {
        if(data.getLevelDataType() != SimpleLevelData.LEVEL_DATA_TYPE)
        {
            Debug.Log("Error: Invalid level data for this loader.");
            return;
        }

        SimpleLevelData levelData = data as SimpleLevelData;

        //Load the level into the game.
        for (int i = 0; i < levelData.getDifficulty(); i++)
        {
            float targetX = Random.Range(X_MIN, X_MAX);
            float targetY = Random.Range(Y_MIN, Y_MAX);
            float targetSize = Random.Range(TARGET_MIN, TARGET_MAX);

            SimpleTarget target = SimpleTarget.create();

            game.addTarget(target, targetX, targetY, targetSize);
        }
        game.setTime(levelData.getTime(), true);
    }
}
