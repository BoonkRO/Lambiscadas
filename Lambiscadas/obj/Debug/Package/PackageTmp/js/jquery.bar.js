(function ($) {

    $.fn.bar = function (options) {
        var opts = $.extend({}, $.fn.bar.defaults, options);
        return this.each(function () {
            $this = $(this);
            var o = $.meta ? $.extend({}, opts, $this.data()) : opts;

            if (!$('.jbar').length && $($this).html() != '') {
                timeout = setTimeout('$.fn.bar.removebar()', o.time);
                var _wrap_bar;
                (o.position == 'bottom') ?
					_wrap_bar = $($this).addClass('jbar jbar-bottom') :
					_wrap_bar = $($this).addClass('jbar jbar-top');

                _wrap_bar.addClass('jbar-content');

                _wrap_bar.css({ "background-color": o.background_color });
                if (o.removebutton) {
                    var _remove_cross = $(document.createElement('a')).addClass('jbar-cross');
                    _remove_cross.click(function (e) { $.fn.bar.removebar(); })
                }
                else {
                    _wrap_bar.css({ "cursor": "pointer" });
                    _wrap_bar.click(function (e) { $.fn.bar.removebar(); })
                }
                _wrap_bar.append(_remove_cross).insertBefore($('.content')).fadeIn('fast');

                _wrap_bar.css('display', '');
            };
        });
    };
    var timeout;
    $.fn.bar.removebar = function (txt) {
        if ($('.jbar').length) {
            clearTimeout(timeout);
            $('.jbar').fadeOut('fast', function () {
                var bar = $('.jbar');
                bar.removeClass('jbar jbar-bottom');
                bar.removeClass('jbar jbar-top');
                bar.removeClass('jbar-content');
            });
        }
    };
    $.fn.bar.defaults = {
        background_color: '#FFFFFF',
        color: '#000',
        position: 'top',
        removebutton: true,
        time: 5000
    };

})(jQuery);