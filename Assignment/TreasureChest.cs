﻿using System;

public enum ChestState
{
    Open,
    Closed,
    Locked
}

public class TreasureChest
{
    private string _material;
    private string _lockType;
    private string _lootQuality;
    private ChestState _state;

    public TreasureChest()
    {
        _material = "Wood";
        _lockType = "None";
        _lootQuality = "Common";
        _state = ChestState.Closed;
    }

    public TreasureChest(string material, string lockType, string lootQuality)
    {
        _material = material;
        _lockType = lockType;
        _lootQuality = lootQuality;
        _state = ChestState.Closed;
    }

    public string Manipulate(string action)
    {
        switch (action.ToLower())
        {
            case "open":
                return Open();
            case "close":
                return Close();
            case "lock":
                return Lock();
            case "unlock":
                return Unlock();
            default:
                return "Invalid action.";
        }
    }

    public string Open()
    {
        switch (_state)
        {
            case ChestState.Open:
                return "Chest is already open.";
            case ChestState.Closed:
                _state = ChestState.Open;
                return "Chest opened.";
            case ChestState.Locked:
                return "Cannot open a locked chest.";
            default:
                return "Invalid chest state.";
        }
    }

    public string Close()
    {
        switch (_state)
        {
            case ChestState.Open:
                _state = ChestState.Closed;
                return "Chest closed.";
            case ChestState.Closed:
                return "Chest is already closed.";
            case ChestState.Locked:
                return "Cannot close a locked chest.";
            default:
                return "Invalid chest state.";
        }
    }

    public string Lock()
    {
        switch (_state)
        {
            case ChestState.Open:
                return "Cannot lock an open chest.";
            case ChestState.Closed:
                _state = ChestState.Locked;
                return "Chest locked.";
            case ChestState.Locked:
                return "Chest is already locked.";
            default:
                return "Invalid chest state.";
        }
    }

    public string Unlock()
    {
        switch (_state)
        {
            case ChestState.Open:
                return "Cannot unlock an open chest.";
            case ChestState.Closed:
                return "Cannot unlock a closed chest.";
            case ChestState.Locked:
                _state = ChestState.Closed;
                return "Chest unlocked.";
            default:
                return "Invalid chest state.";
        }
    }

    public override string ToString()
    {
        return $"Material: {_material}, Lock Type: {_lockType}, Loot Quality: {_lootQuality}, State: {_state}";
    }
}

public static class ConsoleHelper
{
    public static void Write(string text)
    {
        Console.WriteLine(text);
    }
}
