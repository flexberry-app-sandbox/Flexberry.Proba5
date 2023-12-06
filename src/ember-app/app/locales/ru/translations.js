import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

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
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Proba',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Proba',
          title: 'Proba'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
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
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-proba-должность-l': IISProbaДолжностьLForm,
    'i-i-s-proba-сотрудник-l': IISProbaСотрудникLForm,
    'i-i-s-proba-должность-e': IISProbaДолжностьEForm,
    'i-i-s-proba-сотрудник-e': IISProbaСотрудникEForm
  },

});

export default translations;
