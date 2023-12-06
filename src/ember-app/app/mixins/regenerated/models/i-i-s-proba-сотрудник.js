import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  iD: DS.attr('number'),
  дата_приема: DS.attr('date'),
  контакты: DS.attr('string'),
  образование: DS.attr('string'),
  опыт_работы: DS.attr('string'),
  фИО: DS.attr('string'),
  должность: DS.belongsTo('i-i-s-proba-должность', { inverse: null, async: false })
});

export let ValidationRules = {
  iD: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.iD.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  дата_приема: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.дата_приема.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  контакты: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.контакты.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  образование: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.образование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  опыт_работы: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.опыт_работы.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  фИО: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.фИО.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  должность: {
    descriptionKey: 'models.i-i-s-proba-сотрудник.validations.должность.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СотрудникE', 'i-i-s-proba-сотрудник', {
    iD: attr('ID', { index: 0 }),
    фИО: attr('ФИО', { index: 1 }),
    контакты: attr('Контакты', { index: 2 }),
    образование: attr('Образование', { index: 3 }),
    опыт_работы: attr('Опыт_работы', { index: 4 }),
    дата_приема: attr('Дата_приема', { index: 5 }),
    должность: belongsTo('i-i-s-proba-должность', 'Должность', {
      название: attr('Название', { index: 7, hidden: true })
    }, { index: 6, displayMemberPath: 'название' })
  });

  modelClass.defineProjection('СотрудникL', 'i-i-s-proba-сотрудник', {
    iD: attr('ID', { index: 0 }),
    фИО: attr('ФИО', { index: 1 }),
    контакты: attr('Контакты', { index: 2 }),
    образование: attr('Образование', { index: 3 }),
    опыт_работы: attr('Опыт_работы', { index: 4 }),
    дата_приема: attr('Дата_приема', { index: 5 }),
    должность: belongsTo('i-i-s-proba-должность', 'Название', {
      название: attr('Название', { index: 6 })
    }, { index: -1, hidden: true })
  });
};
