import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.proba.caption'),
          title: i18n.t('forms.application.sitemap.proba.title'),
          children: [{
            link: 'i-i-s-proba-должность-l',
            caption: i18n.t('forms.application.sitemap.proba.i-i-s-proba-должность-l.caption'),
            title: i18n.t('forms.application.sitemap.proba.i-i-s-proba-должность-l.title'),
            icon: 'paperclip',
            children: null
          }, {
            link: 'i-i-s-proba-сотрудник-l',
            caption: i18n.t('forms.application.sitemap.proba.i-i-s-proba-сотрудник-l.caption'),
            title: i18n.t('forms.application.sitemap.proba.i-i-s-proba-сотрудник-l.title'),
            icon: 'folder',
            children: null
          }]
        }
      ]
    };
  }),
})