using System.Collections.Generic;
using Interpreter.LexicalAnalysis;

namespace Interpreter.SyntaxAnalysis
{
    internal partial class Syntax_analyzer
    {

        private void Init_table_of_actions()
        {
            Table_of_actions = new Dictionary<Non_terminal, Dictionary<Lexical_analyser.TYPE, Action>>();

            //Start
            Table_of_actions[Non_terminal.Start] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Int] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Start][Lexical_analyser.TYPE.Do] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });

            //Declarations
            Table_of_actions[Non_terminal.Declarations] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Declarations][Lexical_analyser.TYPE.Int] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });

            //Last_declaration
            Table_of_actions[Non_terminal.Last_declaration] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Last_declaration][Lexical_analyser.TYPE.Int] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
    });

            //Declaration_type
            Table_of_actions[Non_terminal.Declaration_type] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Declaration_type][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Get_name,
        Action_type.Empty,
    });

            //Array_decl
            Table_of_actions[Non_terminal.Array_decl] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Array_decl][Lexical_analyser.TYPE.Left_square_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Array_size,
        Action_type.Array_declaration,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Array_decl][Lexical_analyser.TYPE.Semicolon] = new Action(new List<Action_type>
    {
        Action_type.Int_declaration,
    });

            //Statements
            Table_of_actions[Non_terminal.Statements] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Get,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.If] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_1,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Write] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Write,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.Read] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Read,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Statements][Lexical_analyser.TYPE.While] = new Action(new List<Action_type>
    {
        Action_type.Auxiliary_action_4,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_1,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_5,
        Action_type.Empty,
    });

            //Statement
            Table_of_actions[Non_terminal.Statement] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Get,
    });
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.If] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_1,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Write] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Write,
    });
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.Read] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Read,
    });
            Table_of_actions[Non_terminal.Statement][Lexical_analyser.TYPE.While] = new Action(new List<Action_type>
    {
        Action_type.Auxiliary_action_4,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_1,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_5,
    });

            //Else_statement
            Table_of_actions[Non_terminal.Else_statement] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Int] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Do] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.End] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Semicolon] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Left_square_bracket] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Right_square_bracket] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Get] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.If] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Right_round_bracket] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Write] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Read] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.While] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Equal] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Less_or_equal] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Greater_or_equal] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Less] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.More] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Multiply] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Divide] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Eof] = new Action(new List<Action_type> { Action_type.Auxiliary_action_3, });
            Table_of_actions[Non_terminal.Else_statement][Lexical_analyser.TYPE.Else] = new Action(new List<Action_type>
    {
        Action_type.Auxiliary_action_2,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Auxiliary_action_3,
    });

            //Var
            Table_of_actions[Non_terminal.Var] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Var][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
    });

            //Array_var
            Table_of_actions[Non_terminal.Array_var] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Array_var][Lexical_analyser.TYPE.Left_square_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Index,
    });

            //Bool
            Table_of_actions[Non_terminal.Bool] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type>
    {
        Action_type.Num,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_minus,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Bool][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_plus,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });

            //New_bool
            Table_of_actions[Non_terminal.New_bool] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.New_bool][Lexical_analyser.TYPE.Eof] = new Action();

            //And_expr
            Table_of_actions[Non_terminal.And_expr] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type>
    {
        Action_type.Num,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_minus,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.And_expr][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_plus,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });

            //New_and_expr
            Table_of_actions[Non_terminal.New_and_expr] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Eof] = new Action();

            //Comparison
            Table_of_actions[Non_terminal.Comparison] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Equal] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Equal,
    });

            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Less_or_equal] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Less_or_equal,
    });
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Greater_or_equal] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.More_or_equal,
    });
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.Less] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Less,
    });
            Table_of_actions[Non_terminal.Comparison][Lexical_analyser.TYPE.More] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.More,
    });

            //Expr
            Table_of_actions[Non_terminal.Expr] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type>
    {
        Action_type.Num,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_minus,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Expr][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_plus,
        Action_type.Empty,
        Action_type.Empty,
    });

            //New_expr
            Table_of_actions[Non_terminal.New_expr] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Plus,
    });
            Table_of_actions[Non_terminal.New_expr][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Minus,
    });

            //Term
            Table_of_actions[Non_terminal.Term] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type>
    {
        Action_type.Num,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_minus,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Term][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_plus,
        Action_type.Empty,
    });

            //New_term
            Table_of_actions[Non_terminal.New_term] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Id] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Num] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Left_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Minus] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Plus] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Multiply] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Mul,
    });
            Table_of_actions[Non_terminal.New_term][Lexical_analyser.TYPE.Divide] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Div,
    });

            //Unary
            Table_of_actions[Non_terminal.Unary] = new Dictionary<Lexical_analyser.TYPE, Action>();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Int] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Do] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.End] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Semicolon] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Left_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Right_square_bracket] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Get] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.If] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Right_round_bracket] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Write] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Read] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.While] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Else] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Equal] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Less_or_equal] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Greater_or_equal] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Less] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.More] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Multiply] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Divide] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Eof] = new Action();
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Id] = new Action(new List<Action_type>
    {
        Action_type.Id,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Left_round_bracket] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Empty,
    });
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Num] = new Action(new List<Action_type>
    {
        Action_type.Num,
    });
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Minus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_minus,
    });
            Table_of_actions[Non_terminal.Unary][Lexical_analyser.TYPE.Plus] = new Action(new List<Action_type>
    {
        Action_type.Empty,
        Action_type.Empty,
        Action_type.Unar_plus,
    });
        }

        private void Init_table_of_rules()
        {
            Table_of_rules = new Dictionary<Non_terminal, Dictionary<Lexical_analyser.TYPE, Rule>>();

            //Start
            Table_of_rules[Non_terminal.Start] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Int] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Int),
        new State(Non_terminal.Declaration_type),
        new State(Non_terminal.Declarations),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
    });
            Table_of_rules[Non_terminal.Start][Lexical_analyser.TYPE.Do] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
    });

            //Declarations
            Table_of_rules[Non_terminal.Declarations] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Declarations][Lexical_analyser.TYPE.Int] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Int),
        new State(Non_terminal.Declaration_type),
        new State(Non_terminal.Declarations),
    });

            //Last_declaration
            Table_of_rules[Non_terminal.Last_declaration] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Last_declaration][Lexical_analyser.TYPE.Int] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Int),
        new State(Non_terminal.Declaration_type),
    });
            
            //Declaration_type
            Table_of_rules[Non_terminal.Declaration_type] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Declaration_type][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_decl),
    });

            //Array_decl
            Table_of_rules[Non_terminal.Array_decl] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Array_decl][Lexical_analyser.TYPE.Left_square_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_square_bracket),
        new State(Lexical_analyser.TYPE.Num),
        new State(Lexical_analyser.TYPE.Right_square_bracket),
        new State(Lexical_analyser.TYPE.Semicolon),
    });
            Table_of_rules[Non_terminal.Array_decl][Lexical_analyser.TYPE.Semicolon] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Semicolon),
    });

            //Statements
            Table_of_rules[Non_terminal.Statements] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Lexical_analyser.TYPE.Get),
        new State(Non_terminal.Expr),
        new State(Lexical_analyser.TYPE.Semicolon),
        new State(Non_terminal.Statements),
    });
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.If] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.If),
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
        new State(Non_terminal.Else_statement),
        new State(Non_terminal.Statements),
    });
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Write] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Write),
        new State(Non_terminal.Var),
        new State(Lexical_analyser.TYPE.Semicolon),
        new State(Non_terminal.Statements),
    });
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.Read] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Read),
        new State(Non_terminal.Var),
        new State(Lexical_analyser.TYPE.Semicolon),
        new State(Non_terminal.Statements),
    });
            Table_of_rules[Non_terminal.Statements][Lexical_analyser.TYPE.While] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.While),
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
        new State(Non_terminal.Statements),
    });

            //Statement
            Table_of_rules[Non_terminal.Statement] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Lexical_analyser.TYPE.Get),
        new State(Non_terminal.Expr),
        new State(Lexical_analyser.TYPE.Semicolon),
    });
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.If] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.If),
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
        new State(Non_terminal.Else_statement),
    });
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Write] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Write),
        new State(Non_terminal.Var),
        new State(Lexical_analyser.TYPE.Semicolon),
    });
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.Read] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Read),
        new State(Non_terminal.Var),
        new State(Lexical_analyser.TYPE.Semicolon),
    });
            Table_of_rules[Non_terminal.Statement][Lexical_analyser.TYPE.While] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.While),
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
    });

            //Else_statement
            Table_of_rules[Non_terminal.Else_statement] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Else_statement][Lexical_analyser.TYPE.Else] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Else),
        new State(Lexical_analyser.TYPE.Do),
        new State(Non_terminal.Statements),
        new State(Lexical_analyser.TYPE.End),
        new State(),
    });

            //Var
            Table_of_rules[Non_terminal.Var] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Var][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
    });

            //Array_var
            Table_of_rules[Non_terminal.Array_var] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Array_var][Lexical_analyser.TYPE.Left_square_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_square_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_square_bracket),
    });

            //Bool
            Table_of_rules[Non_terminal.Bool] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
        new State(Non_terminal.New_bool),
    });
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Left_round_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
        new State(Non_terminal.New_bool),
    });
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Num] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Num),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
        new State(Non_terminal.New_bool),
    });
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
        new State(Non_terminal.New_bool),
    });
            Table_of_rules[Non_terminal.Bool][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
        new State(Non_terminal.New_bool),
    });

            //New_bool
            Table_of_rules[Non_terminal.New_bool] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.New_bool][Lexical_analyser.TYPE.Eof] = new Rule();

            //And_expr
            Table_of_rules[Non_terminal.And_expr] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
    });
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
    });
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Num] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Num),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
    });
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
    });
            Table_of_rules[Non_terminal.And_expr][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
        new State(Non_terminal.Comparison),
        new State(Non_terminal.New_and_expr),
    });

            //New_and_expr
            Table_of_rules[Non_terminal.New_and_expr] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.New_and_expr][Lexical_analyser.TYPE.Eof] = new Rule();

            //Comparison
            Table_of_rules[Non_terminal.Comparison] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Equal] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Equal),
        new State(Non_terminal.Expr),
        new State(),
    });

            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Less_or_equal] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Less_or_equal),
        new State(Non_terminal.Expr),
        new State(),
    });
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Greater_or_equal] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Greater_or_equal),
        new State(Non_terminal.Expr),
        new State(),
    });
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.Less] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Less),
        new State(Non_terminal.Expr),
        new State(),
    });
            Table_of_rules[Non_terminal.Comparison][Lexical_analyser.TYPE.More] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.More),
        new State(Non_terminal.Expr),
        new State(),
    });

            //Expr
            Table_of_rules[Non_terminal.Expr] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
    });
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Left_round_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
    });
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Num] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Num),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
    });
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
    });
            Table_of_rules[Non_terminal.Expr][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
        new State(Non_terminal.New_expr),
    });

            //New_expr
            Table_of_rules[Non_terminal.New_expr] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Term),
        new State(Non_terminal.New_expr),
    });
            Table_of_rules[Non_terminal.New_expr][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Term),
        new State(Non_terminal.New_expr),
    });

            //Term
            Table_of_rules[Non_terminal.Term] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
        new State(Non_terminal.New_term),
    });
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Left_round_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
        new State(Non_terminal.New_term),
    });
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Num] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Num),
        new State(Non_terminal.New_term),
    });
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
    });
            Table_of_rules[Non_terminal.Term][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Unary),
        new State(),
        new State(Non_terminal.New_term),
    });

            //New_term
            Table_of_rules[Non_terminal.New_term] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Id] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Num] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Left_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Minus] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Plus] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Multiply] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Multiply),
        new State(Non_terminal.Unary),
        new State(Non_terminal.New_term),
    });
            Table_of_rules[Non_terminal.New_term][Lexical_analyser.TYPE.Divide] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Divide),
        new State(Non_terminal.Unary),
        new State(Non_terminal.New_term),
    });

            //Unary
            Table_of_rules[Non_terminal.Unary] = new Dictionary<Lexical_analyser.TYPE, Rule>();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Int] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Do] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.End] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Semicolon] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Left_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Right_square_bracket] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Get] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.If] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Right_round_bracket] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Write] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Read] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.While] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Else] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Equal] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Less_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Greater_or_equal] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Less] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.More] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Multiply] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Divide] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Eof] = new Rule();
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Id] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Id),
        new State(Non_terminal.Array_var),
    });
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Left_round_bracket] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Left_round_bracket),
        new State(Non_terminal.Bool),
        new State(Lexical_analyser.TYPE.Right_round_bracket),
    });
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Num] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Num),
    });
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Minus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Minus),
        new State(Non_terminal.Unary),
        new State(),
    });
            Table_of_rules[Non_terminal.Unary][Lexical_analyser.TYPE.Plus] = new Rule(new List<State>
    {
        new State(Lexical_analyser.TYPE.Plus),
        new State(Non_terminal.Unary),
        new State(),
    });
        }

    }
}