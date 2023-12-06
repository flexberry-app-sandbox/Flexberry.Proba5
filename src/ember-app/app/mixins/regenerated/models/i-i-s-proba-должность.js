import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  iD: DS.attr('number'),
  название: DS.attr('string'),
  оклад: DS.attr('number')
});

export let ValidationRules = {
  iD: {
    descriptionKey: 'models.i-i-s-proba-должность.validations.iD.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  название: {
    descriptionKey: 'models.i-i-s-proba-должность.validations.название.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  оклад: {
    descriptionKey: 'models.i-i-s-proba-должность.validations.оклад.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ДолжностьE', 'i-i-s-proba-должность', {
    iD: attr('ID', { index: 0 }),
    название: attr('Название', { index: 1 }),
    оклад: attr('Оклад', { index: 2 })
  });

  modelClass.defineProjection('ДолжностьL', 'i-i-s-proba-должность', {
    iD: attr('ID', { index: 0 }),
    название: attr('Название', { index: 1 }),
    оклад: attr('Оклад', { index: 2 })
  });
};
