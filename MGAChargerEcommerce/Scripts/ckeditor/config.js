/**
 * @license Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.html or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    //config.language = 'fr';
    //config.uiColor = '#AADC6E';
    config.height = 350;        // 500 pixels high.
    config.height = '350';     // CSS unit (em).

    config.toolbar = [
    ['Cut', 'Copy','Save', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Scayt'],
    ['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
    ['Image', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'Link', 'Unlink', 'Anchor', 'Maximize'],
    '/',
    ['Styles', 'Format', 'Font', 'FontSize', 'Bold', 'Italic', 'Strike', 'NumberedList', 'BulletedList', 'Outdent', 'Indent', 'Blockquote', 'TextColor', 'BGColor'],
    ];
};
