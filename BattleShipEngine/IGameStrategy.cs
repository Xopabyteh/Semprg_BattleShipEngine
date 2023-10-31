﻿namespace BattleShipEngine;

public interface IGameStrategy
{
    /// <summary>
    /// Get's the move of this strategy. This is called by the game engine. If the result hit a boat on the board, the game engine will call <see cref="RespondHit"/>. If the result missed a boat on the board, the game engine will call <see cref="RespondMiss"/>.
    /// </summary>
    /// <returns>A 2D point on the board where the player wants to shoot. The point must always be within the board!</returns>
    Int2 GetMove();

    /// <summary>
    /// This is called by the game engine when the result of <see cref="GetMove"/> hit a boat on the board.
    /// </summary>
    void RespondHit();

    /// <summary>
    /// This is called by the game engine when the result of <see cref="GetMove"/> missed a boat on the board.
    /// </summary>
    void RespondMiss();
}