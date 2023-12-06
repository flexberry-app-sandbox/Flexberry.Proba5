import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISProbaДолжностьLForm from './forms/i-i-s-proba-должность-l';
import IISProbaСотрудникLForm from './forms/i-i-s-proba-сотрудник-l';
import IISProbaДолжностьEForm from './forms/i-i-s-proba-должность-e';
import IISProbaСотрудникEForm from './forms/i-i-s-proba-сотрудник-e';
import IISProbaДолжностьModel from './models/i-i-s-proba-должность';
import IISProbaСотрудникModel from './models/i-i-s-proba-сотрудник';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-proba-должность': IISProbaДолжностьModel,
    'i-i-s-proba-сотрудник': IISProbaСотрудникModel
  },

  'application-name': 'Proba',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Proba',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Proba',
          title: 'Proba'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        proba: {
          caption: 'Proba',
          title: 'Proba',
          'i-i-s-proba-должность-l': {
            caption: 'Должность',
            title: ''
          },
          'i-i-s-proba-сотрудник-l': {
            caption: 'Сотрудник',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-proba-должность-l': IISProbaДолжностьLForm,
    'i-i-s-proba-сотрудник-l': IISProbaСотрудникLForm,
    'i-i-s-proba-должность-e': IISProbaДолжностьEForm,
    'i-i-s-proba-сотрудник-e': IISProbaСотрудникEForm
  },

});

export default translations;
