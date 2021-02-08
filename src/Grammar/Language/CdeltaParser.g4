parser grammar CdeltaParser;

options { tokenVocab=CdeltaLexer; }

// PARSER RULES
codeFile			: namespace EOF;

namespace : NAMESPACE IDENTIFIER (DOT IDENTIFIER)* CURLY_OPEN automatonDefinition automatonDefinition*? CURLY_CLOSE;

automatonDefinition	: accessModifier? ABSTRACT? PARTIAL? AUTOMATON IDENTIFIER (LESS_THAN automatonDataType GREATER_THAN)? CURLY_OPEN automatonBody CURLY_CLOSE;

accessModifier
	: PROTECTED INTERNAL
	| PRIVATE PROTECTED
	| PUBLIC
	| INTERNAL
	| PROTECTED
	| PRIVATE;

automatonDataType	: (~(GREATER_THAN))+;

automatonBody		: (stateDefinition | transitionDefinition)*;

stateDefinition		: START? END? STATE IDENTIFIER (SEMICOLON | (CURLY_OPEN stateInnerBlock CURLY_CLOSE));
stateInnerBlock
	: stateEnter? stateExit?
	| stateExit? stateEnter?
	;
stateEnter			: ENTER SEMICOLON;
stateExit			: EXIT SEMICOLON;

transitionDefinition: TRANSITION IDENTIFIER IDENTIFIER (SEMICOLON | (CURLY_OPEN transitionInnerBlock CURLY_CLOSE));
transitionInnerBlock: transitionEnter?;
transitionEnter		: ENTER SEMICOLON;