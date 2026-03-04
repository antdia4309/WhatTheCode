using WhatTheCode.Models;

namespace WhatTheCode.Services
{
    public class CommandResult
    {
        public bool Success { get; init; }
        public string Message { get; init; } = string.Empty;
    }

    public class CommandEngine
    {
        private readonly Grid _grid;
        private readonly Character _character;

        public CommandEngine(Grid grid, Character character)
        {
            _grid = grid;
            _character = character;
        }

        public CommandResult Execute(string command)
        {
            return command.ToLower().Trim() switch
            {
                "moveforward"  => HandleMoveForward(),
                "turnleft"     => HandleTurn(left: true),
                "turnright"    => HandleTurn(left: false),
                "reset"        => HandleReset(),
                _              => new CommandResult { Success = false, Message = $"Unknown command: '{command}'" }
            };
        }

        private CommandResult HandleMoveForward()
        {
            bool moved = _character.MoveForward(_grid.Columns, _grid.Rows);

            if (moved)
            {
                _grid.MarkVisited(_character.X, _character.Y);
                return new CommandResult
                {
                    Success = true,
                    Message = $"Moved to ({_character.X}, {_character.Y})."
                };
            }

            return new CommandResult
            {
                Success = false,
                Message = "Blocked! Can't move outside the grid."
            };
        }

        private CommandResult HandleTurn(bool left)
        {
            if (left) _character.TurnLeft();
            else _character.TurnRight();

            return new CommandResult
            {
                Success = true,
                Message = $"Now facing {_character.Facing}."
            };
        }

        private CommandResult HandleReset()
        {
            _character.Reset(0, 0);
            _grid.Reset();
            return new CommandResult { Success = true, Message = "Grid reset." };
        }
    }
}